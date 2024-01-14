using Microsoft.EntityFrameworkCore;
using LoncotesLibrary.Models;

public class LoncotesLibraryDbContext : DbContext
{

    public DbSet<Checkout> Checkouts { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Material> Materials { get; set; }
    public DbSet<MaterialType> MaterialTypes { get; set; }
    public DbSet<Patron> Patrons { get; set; }

    public LoncotesLibraryDbContext(DbContextOptions<LoncotesLibraryDbContext> context) : base(context)
    {

    }

protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Checkout>().HasData(new Checkout[]
        {
            new Checkout {Id = 1, MaterialId = 1, PatronId = 1,CheckoutDate = DateTime.Today, ReturnDate = null },
            new Checkout {Id = 2, MaterialId = 2, PatronId = 2,CheckoutDate = DateTime.Today, ReturnDate = null },
            new Checkout {Id = 3, MaterialId = 3, PatronId = 3,CheckoutDate = DateTime.Today, ReturnDate = null },
            new Checkout {Id = 4, MaterialId = 4, PatronId = 4,CheckoutDate = DateTime.Today, ReturnDate = null }
        });

        // seed data with genres
        modelBuilder.Entity<Genre>().HasData(new Genre[]
        {
            new Genre {Id = 1, Name = "Genre 1"},
            new Genre {Id = 2, Name = "Genre 2"},
            new Genre {Id = 3, Name = "Genre 3"},
            new Genre {Id = 4, Name = "Genre 4"},
            new Genre {Id = 5, Name = "Genre 5"},
        });
        // Might need to seed more data 
        modelBuilder.Entity<Material>().HasData(new Material[]
        {
            new Material {Id = 1, MaterialName = "Made up Material Name 1", MaterialTypeId = 1, GenreId = 1, OutOfCirculationSince = DateTime.Now.AddDays(-10)},
            new Material {Id = 2, MaterialName = "Made up Material Name 2", MaterialTypeId = 2, GenreId = 2, OutOfCirculationSince = DateTime.Now.AddDays(-5)},
            new Material {Id = 3, MaterialName = "Made up Material Name 3", MaterialTypeId = 3, GenreId = 3, OutOfCirculationSince = DateTime.Now.AddDays(-3)},
            new Material {Id = 4, MaterialName = "Made up Material Name 4", MaterialTypeId = 4, GenreId = 4, OutOfCirculationSince = DateTime.Now.AddDays(-8)},
            new Material {Id = 5, MaterialName = "Made up Material Name 5", MaterialTypeId = 1, GenreId = 2, OutOfCirculationSince = DateTime.Now.AddDays(-12)},
            new Material {Id = 6, MaterialName = "Made up Material Name 6", MaterialTypeId = 2, GenreId = 3, OutOfCirculationSince = DateTime.Now.AddDays(-6)},
            new Material {Id = 7, MaterialName = "Made up Material Name 7", MaterialTypeId = 3, GenreId = 4, OutOfCirculationSince = DateTime.Now.AddDays(-9)},
            new Material {Id = 8, MaterialName = "Made up Material Name 8", MaterialTypeId = 4, GenreId = 5, OutOfCirculationSince = DateTime.Now.AddDays(-4)},
            new Material {Id = 9, MaterialName = "Made up Material Name 9", MaterialTypeId = 1, GenreId = 3, OutOfCirculationSince = DateTime.Now.AddDays(-7)},
            new Material {Id = 10, MaterialName = "Made up Material Name 10", MaterialTypeId = 2, GenreId = 4, OutOfCirculationSince = DateTime.Now.AddDays(-11)},
            new Material {Id = 11, MaterialName = "Made up Material Name 11", MaterialTypeId = 5, GenreId = 5, OutOfCirculationSince = DateTime.Now.AddDays(-2)}
        });

       modelBuilder.Entity<MaterialType>().HasData(new MaterialType[]
        {
            new MaterialType {Id = 1, Name = "Made up Material Type Name 1",CheckoutDays=1},
            new MaterialType {Id = 2, Name = "Made up Material Type Name 2",CheckoutDays=2},
            new MaterialType {Id = 3, Name = "Made up Material Type Name 3",CheckoutDays=3},
            new MaterialType {Id = 4, Name = "Made up Material Type Name 4",CheckoutDays=4},
            new MaterialType {Id = 5, Name = "Made up Material Type Name 5",CheckoutDays=5},
                    
        });

        modelBuilder.Entity<Patron>().HasData(new Patron[]
        {
            new Patron {Id = 1, FirstName = "John", LastName = "Doe", Address = "123 Main St", Email = "john.doe@example.com", IsActive = true},
            new Patron {Id = 2, FirstName = "Jane", LastName = "Smith", Address = "456 Oak Ave", Email = "jane.smith@example.com", IsActive = true},
            new Patron {Id = 3, FirstName = "Bob", LastName = "Johnson", Address = "789 Pine St", Email = "bob.johnson@example.com", IsActive = true},
            new Patron {Id = 4, FirstName = "Alice", LastName = "Williams", Address = "987 Elm St", Email = "alice.williams@example.com", IsActive = true},
            new Patron {Id = 5, FirstName = "Charlie", LastName = "Brown", Address = "654 Birch Ave", Email = "charlie.brown@example.com", IsActive = true},
        });



    }














}