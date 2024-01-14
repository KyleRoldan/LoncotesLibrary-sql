using LoncotesLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using LoncotesLibrary.Models.DTOs;


//////////DONT TOUCH THIS CODE//////////////////////////////////////////////////////////////////////////////////////


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// allows passing datetimes without time zone data 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// allows our api endpoints to access the database through Entity Framework Core
builder.Services.AddNpgsql<LoncotesLibraryDbContext>(builder.Configuration["CreekRiverDbConnectionString"]);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//////////////GET ALL MATERIALS///////////////////////////////////////////////////////////////////////////////////////

app.MapGet("/api/materials", (LoncotesLibraryDbContext db, int? materialTypeId, int? genreId) =>
{
    return db.Materials
        .Where(r => (!materialTypeId.HasValue || r.MaterialTypeId == materialTypeId.Value)
                 && (!genreId.HasValue || r.GenreId == genreId.Value))
        .Select(r => new MaterialDTO
        {
            Id = r.Id,
            MaterialName = r.MaterialName,
            MaterialTypeId = r.MaterialTypeId,
            GenreId = r.GenreId,

            Genre = new GenreDTO
            {
                Id = r.Genre.Id,
                Name = r.Genre.Name,
            },
            MaterialType = new MaterialTypeDTO
            {
                Id = r.MaterialType.Id,
                Name = r.MaterialType.Name,
            }
        })
        .ToList();
});

////////////GET ALL GENRES////////////////////////////////////////////////////////////////


app.MapGet("/api/genres", (LoncotesLibraryDbContext db) =>
{
    return db.Genres
        .Select(c => new GenreDTO
        {
            Id = c.Id,
            Name = c.Name,
        }).ToList();
});

//////////GET MATERIALS BY ID//////////////////////////////////////////////////////////////////////////////////////



app.MapGet("/api/materials/{id}", (LoncotesLibraryDbContext db, int id) =>
{
    var material = db.Materials
        .Include(m => m.Genre)
        .Include(m => m.MaterialType)
        .Include(m => m.Checkouts)
            .ThenInclude(co => co.Patron)
        .Where(m => m.Id == id)
        .Select(m => new MaterialDTO
        {
            Id = m.Id,
            MaterialName = m.MaterialName,
            MaterialTypeId = m.MaterialTypeId,
            GenreId = m.GenreId,
            Genre = new GenreDTO
            {
                Id = m.Genre.Id,
                Name = m.Genre.Name,
            },
            MaterialType = new MaterialTypeDTO
            {
                Id = m.MaterialType.Id,
                Name = m.MaterialType.Name,
            },
            Checkouts = m.Checkouts.Select(co => new CheckoutDTO
            {
                Id = co.Id,
                CheckoutDate = co.CheckoutDate,
                ReturnDate = co.ReturnDate,
                Patron = new PatronDTO
                {
                    Id = co.Patron.Id,
                    FirstName = co.Patron.FirstName,
                    LastName = co.Patron.LastName,
                }
            }).ToList()
        })
        .FirstOrDefault();

    return material;
});
////////CREATE MATERIAL////////////////////////////////////////////////////////////////////////////
app.MapPost("/api/materials", (LoncotesLibraryDbContext db, Material material) =>
{
    db.Materials.Add(material);
    db.SaveChanges();
    return Results.Created($"/api/campsites/{material.Id}", material);
});

//////////?????????Remove a Material From Circulation????????////////////////////////////////////////


//Add an endpoint that expects an id in the url, which sets 
//the OutOfCirculationSince property of the material that matches 
//the material id to DateTime.Now. (This is called a soft delete, 
//where a row is not deleted from the database, but instead has a 
//flag that says the row is no longer active.) The endpoint to get all 
//materials should already be filtering these items out.

///////GET ALL MATERIALTYPES///////////////////////////////////////////////////////////////////////
app.MapGet("/api/materialTypes", (LoncotesLibraryDbContext db) =>
{
    return db.MaterialTypes
        .Select(c => new MaterialTypeDTO
        {
            Id = c.Id,
            Name = c.Name,
            CheckoutDays = c.CheckoutDays
        }).ToList();
});

/////GET ALL PATRONS/////////////////////////////////////////////////////////////////////////////
app.MapGet("/api/patrons", (LoncotesLibraryDbContext db) =>
{
    return db.Patrons
        .Select(c => new PatronDTO
        {
            Id = c.Id,
            FirstName = c.FirstName,
            LastName = c.LastName,
            Address = c.Address,
            Email = c.Email,
            IsActive = c.IsActive

        }).ToList();
});

/////GET PATRON BY CHECKOUTS - INCLUDE MATERIALS AND MATERIALS TYPE//////////////////////////////////////////


app.MapGet("/api/patrons/{id}/checkouts", (LoncotesLibraryDbContext db, int id) =>
{
    var patron = db.Patrons
    .Include(p => p.Checkouts)/////include checkouts
    .ThenInclude(co => co.Material)//////include material it is also not in the original table
    .ThenInclude(m => m.MaterialType)//////include material type
    .FirstOrDefault(p => p.Id == id);//////make it synchronius 

    if (patron == null)
    {
        return Results.NotFound();
    }

    var patronWithCheckouts = new PatronDTO
    {
        Id = patron.Id,
        FirstName = patron.FirstName,
        LastName = patron.LastName,
        Address = patron.Address,
        Email = patron.Email,
        IsActive = patron.IsActive,
        Checkouts = patron.Checkouts.Select(co => new CheckoutDTO
        {
            Id = co.Id,
            CheckoutDate = co.CheckoutDate,
            ReturnDate = co.ReturnDate,
            Material = new MaterialDTO
            {
                Id = co.Material.Id,
                MaterialName = co.Material.MaterialName,
                MaterialTypeId = co.Material.MaterialTypeId,
                GenreId = co.Material.GenreId,

                MaterialType = new MaterialTypeDTO
                {
                    Id = co.Material.MaterialType.Id,
                    Name = co.Material.MaterialType.Name,
                }
            }
        }).ToList()
    };

    return Results.Json(patronWithCheckouts);
});



///////////////UPDATE PATRON///////////////////////////////////////////////////////////////////////////////////////////
app.MapPut("/api/patrons/{id}", (LoncotesLibraryDbContext db, int id, Patron patron) =>
{
    Patron patronToUpdate = db.Patrons.SingleOrDefault(patron => patron.Id == id);
    if (patronToUpdate == null)
    {
        return Results.NotFound();
    }
    patronToUpdate.FirstName = patron.FirstName;
    patronToUpdate.LastName = patron.LastName;
    patronToUpdate.Address = patron.Address;
    patronToUpdate.Email = patron.Email;
    patronToUpdate.IsActive = patron.IsActive;

    db.SaveChanges();
    return Results.NoContent();
});

///////////////SOFT DELETE PATRON///////////////////////////////////////////////////////////////////////////////////////////
app.MapDelete("/api/patrons/{id}", (LoncotesLibraryDbContext db, int id) =>
{
    var patronToDelete = db.Patrons.Find(id);

    if (patronToDelete == null)
    {
        return Results.NotFound();
    }

    // Soft delete by setting IsActive to false
    patronToDelete.IsActive = false;

    db.SaveChanges();


    return Results.NoContent();
});

//////////CREATE CHECKOUT FOR PATRON AND MATERIAL/////////////////////////////////////////////////////////////////////////////////////


////////////////////////NOT WORKING NEEDS FIXING////////////////////////////////////////////////////
///The librarians need to be able to checkout items 
///for patrons. Add an endpoint to create a new Checkout for a material and patron. 
///Automatically set the checkout date to DateTime.Today.




app.MapPost("/api/checkouts", (LoncotesLibraryDbContext db, CheckoutWithLateFeeDTO checkoutDTO) =>
{
    var materialId = checkoutDTO.MaterialId;
    var patronId = checkoutDTO.PatronId;

    // Ensure the material and patron exist
    var material = db.Materials.Find(materialId);
    var patron = db.Patrons.Find(patronId);

    if (material == null || patron == null)
    {
        return Results.NotFound("Material or patron not found");
    }

    // Check if the material is already checked out
    var existingCheckout = db.Checkouts
        .FirstOrDefault(c => c.MaterialId == materialId && c.ReturnDate == null);

    if (existingCheckout != null)
    {
        return Results.BadRequest("Material is already checked out");
    }

    // Create a new checkout
    var newCheckout = new Checkout
    {
        MaterialId = materialId,
        PatronId = patronId,
        CheckoutDate = DateTime.Today,
        ReturnDate = null // ReturnDate is initially set to null
    };

    // Add the checkout to the database
    db.Checkouts.Add(newCheckout);
    db.SaveChanges();

    return Results.Created($"/api/checkouts/{newCheckout.Id}", newCheckout);
});


///////RETURN A MATERIAL--MARK MATERIAL AS CHECKEDOUT///////////////////////////////////////////////////////////////////////////

app.MapPut("/api/checkouts/{id}/return", (LoncotesLibraryDbContext db, int id) =>
{
    var checkout = db.Checkouts.Find(id);

    if (checkout == null)
    {
        return Results.NotFound("Checkout not found");
    }

    // Check if already returned
    if (checkout.ReturnDate.HasValue)
    {
        return Results.BadRequest("Item is already returned");
    }

    // Mark as returned with todays date
    checkout.ReturnDate = DateTime.Today;

    
    db.SaveChanges();

    return Results.NoContent();
});

///////GET CHECKOUTS//////////////////////////////////////////////////////////////////////////////////////////////////////////////

app.MapGet("/api/checkouts", (LoncotesLibraryDbContext db)=>

{
    return db.Checkouts
        .Select(c => new CheckoutDTO
        {
            Id = c.Id,
            MaterialId = c.MaterialId,
            PatronId = c.PatronId,
            CheckoutDate = c.CheckoutDate,
            ReturnDate = c.ReturnDate
        }).ToList();
});
///////GET ONLY AVAILABLE MATERIAL//////////////////////////////////////////////////////////////////////////////////////////////////


app.MapGet("/materials/available", (LoncotesLibraryDbContext db) =>
{
    return db.Materials///GET ALL CIRCULATING MATERIALS///////////////////////
    .Where(m => m.OutOfCirculationSince == null)///FILTER OUT MATERIALS THAT HAVE A NULL RETURNDATE / NO DATA////////////
    .Where(m => m.Checkouts.All(co => co.ReturnDate != null))//only return materials where all of the material's checkouts have a value for ReturnDate////
    .Select(material => new MaterialDTO//transform the Material objects into MaterialDTOs to send back to the client
    {
        Id = material.Id,
        MaterialName = material.MaterialName,
        MaterialTypeId = material.MaterialTypeId,
        GenreId = material.GenreId,
        OutOfCirculationSince = material.OutOfCirculationSince
    })
    .ToList();
});

///////GET OVERDUE CHECKOUTS//////////////////////////////////////////////////////////////////////

app.MapGet("/api/checkouts/overdue", (LoncotesLibraryDbContext db) =>
{
    return db.Checkouts
    .Include(p => p.Patron)
    .Include(co => co.Material)
    .ThenInclude(m => m.MaterialType)
     //This endpoint gets ALL checkouts and includes 
     //the Patron, Material, and MaterialType data that belong to each Checkout.

    .Where(co =>
        (DateTime.Today - co.CheckoutDate.Value).Days >
        co.Material.MaterialType.CheckoutDays &&
        co.ReturnDate == null)
        .Select(co => new CheckoutDTO
        {
            Id = co.Id,
            MaterialId = co.MaterialId,
            Material = new MaterialDTO
            {
                Id = co.Material.Id,
                MaterialName = co.Material.MaterialName,
                MaterialTypeId = co.Material.MaterialTypeId,
                MaterialType = new MaterialTypeDTO
                {
                    Id = co.Material.MaterialTypeId,
                    Name = co.Material.MaterialType.Name,
                    CheckoutDays = co.Material.MaterialType.CheckoutDays
                },
                GenreId = co.Material.GenreId,
                OutOfCirculationSince = co.Material.OutOfCirculationSince
            },
            PatronId = co.PatronId,
            Patron = new PatronDTO
            {
                Id = co.Patron.Id,
                FirstName = co.Patron.FirstName,
                LastName = co.Patron.LastName,
                Address = co.Patron.Address,
                Email = co.Patron.Email,
                IsActive = co.Patron.IsActive
            },
            CheckoutDate = co.CheckoutDate,
            ReturnDate = co.ReturnDate
        })
    .ToList();
});

///////////////////////NEED TO FINISH///////////////////////////////////////////////////////////////////

// Add another calculated property to the Patron class called Balance that totals 
// up the unpaid fines that a patron owes. Add a Paid property of type bool to the
//  Checkout class that indicates whether a fee has been paid or not. Try to use 
//  the method in this and the previous chapters to break the problem down. Start 
//  with a description of the problem, and then pseudo-code. Slowly turn parts of 
//  the pseudo-code into actual code as you figure out how to solve each piece.




app.Run();
 