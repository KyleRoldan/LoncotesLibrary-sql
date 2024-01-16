﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LoncotesLibrary.Migrations
{
    [DbContext(typeof(LoncotesLibraryDbContext))]
    [Migration("20240115010528_Checkoutpaid")]
    partial class Checkoutpaid
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LoncotesLibrary.Models.Checkout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CheckoutDate")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("MaterialId")
                        .HasColumnType("integer");

                    b.Property<bool>("Paid")
                        .HasColumnType("boolean");

                    b.Property<int>("PatronId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("MaterialId");

                    b.HasIndex("PatronId");

                    b.ToTable("Checkouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CheckoutDate = new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaterialId = 1,
                            Paid = true,
                            PatronId = 1
                        },
                        new
                        {
                            Id = 2,
                            CheckoutDate = new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaterialId = 2,
                            Paid = true,
                            PatronId = 2
                        },
                        new
                        {
                            Id = 3,
                            CheckoutDate = new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaterialId = 3,
                            Paid = true,
                            PatronId = 3
                        },
                        new
                        {
                            Id = 4,
                            CheckoutDate = new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaterialId = 4,
                            Paid = false,
                            PatronId = 4
                        });
                });

            modelBuilder.Entity("LoncotesLibrary.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Genre 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Genre 2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Genre 3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Genre 4"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Genre 5"
                        });
                });

            modelBuilder.Entity("LoncotesLibrary.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("GenreId")
                        .HasColumnType("integer");

                    b.Property<string>("MaterialName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("MaterialTypeId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("OutOfCirculationSince")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("MaterialTypeId");

                    b.ToTable("Materials");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenreId = 1,
                            MaterialName = "Made up Material Name 1",
                            MaterialTypeId = 1,
                            OutOfCirculationSince = new DateTime(2024, 1, 4, 20, 5, 28, 613, DateTimeKind.Local).AddTicks(530)
                        },
                        new
                        {
                            Id = 2,
                            GenreId = 2,
                            MaterialName = "Made up Material Name 2",
                            MaterialTypeId = 2,
                            OutOfCirculationSince = new DateTime(2024, 1, 9, 20, 5, 28, 613, DateTimeKind.Local).AddTicks(540)
                        },
                        new
                        {
                            Id = 3,
                            GenreId = 3,
                            MaterialName = "Made up Material Name 3",
                            MaterialTypeId = 3,
                            OutOfCirculationSince = new DateTime(2024, 1, 11, 20, 5, 28, 613, DateTimeKind.Local).AddTicks(540)
                        },
                        new
                        {
                            Id = 4,
                            GenreId = 4,
                            MaterialName = "Made up Material Name 4",
                            MaterialTypeId = 4,
                            OutOfCirculationSince = new DateTime(2024, 1, 6, 20, 5, 28, 613, DateTimeKind.Local).AddTicks(540)
                        },
                        new
                        {
                            Id = 5,
                            GenreId = 2,
                            MaterialName = "Made up Material Name 5",
                            MaterialTypeId = 1,
                            OutOfCirculationSince = new DateTime(2024, 1, 2, 20, 5, 28, 613, DateTimeKind.Local).AddTicks(550)
                        },
                        new
                        {
                            Id = 6,
                            GenreId = 3,
                            MaterialName = "Made up Material Name 6",
                            MaterialTypeId = 2,
                            OutOfCirculationSince = new DateTime(2024, 1, 8, 20, 5, 28, 613, DateTimeKind.Local).AddTicks(550)
                        },
                        new
                        {
                            Id = 7,
                            GenreId = 4,
                            MaterialName = "Made up Material Name 7",
                            MaterialTypeId = 3,
                            OutOfCirculationSince = new DateTime(2024, 1, 5, 20, 5, 28, 613, DateTimeKind.Local).AddTicks(550)
                        },
                        new
                        {
                            Id = 8,
                            GenreId = 5,
                            MaterialName = "Made up Material Name 8",
                            MaterialTypeId = 4,
                            OutOfCirculationSince = new DateTime(2024, 1, 10, 20, 5, 28, 613, DateTimeKind.Local).AddTicks(550)
                        },
                        new
                        {
                            Id = 9,
                            GenreId = 3,
                            MaterialName = "Made up Material Name 9",
                            MaterialTypeId = 1,
                            OutOfCirculationSince = new DateTime(2024, 1, 7, 20, 5, 28, 613, DateTimeKind.Local).AddTicks(550)
                        },
                        new
                        {
                            Id = 10,
                            GenreId = 4,
                            MaterialName = "Made up Material Name 10",
                            MaterialTypeId = 2,
                            OutOfCirculationSince = new DateTime(2024, 1, 3, 20, 5, 28, 613, DateTimeKind.Local).AddTicks(560)
                        },
                        new
                        {
                            Id = 11,
                            GenreId = 5,
                            MaterialName = "Made up Material Name 11",
                            MaterialTypeId = 5,
                            OutOfCirculationSince = new DateTime(2024, 1, 12, 20, 5, 28, 613, DateTimeKind.Local).AddTicks(560)
                        });
                });

            modelBuilder.Entity("LoncotesLibrary.Models.MaterialType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CheckoutDays")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MaterialTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CheckoutDays = 1,
                            Name = "Made up Material Type Name 1"
                        },
                        new
                        {
                            Id = 2,
                            CheckoutDays = 2,
                            Name = "Made up Material Type Name 2"
                        },
                        new
                        {
                            Id = 3,
                            CheckoutDays = 3,
                            Name = "Made up Material Type Name 3"
                        },
                        new
                        {
                            Id = 4,
                            CheckoutDays = 4,
                            Name = "Made up Material Type Name 4"
                        },
                        new
                        {
                            Id = 5,
                            CheckoutDays = 5,
                            Name = "Made up Material Type Name 5"
                        });
                });

            modelBuilder.Entity("LoncotesLibrary.Models.Patron", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Patrons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main St",
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            IsActive = true,
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Oak Ave",
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            IsActive = true,
                            LastName = "Smith"
                        },
                        new
                        {
                            Id = 3,
                            Address = "789 Pine St",
                            Email = "bob.johnson@example.com",
                            FirstName = "Bob",
                            IsActive = true,
                            LastName = "Johnson"
                        },
                        new
                        {
                            Id = 4,
                            Address = "987 Elm St",
                            Email = "alice.williams@example.com",
                            FirstName = "Alice",
                            IsActive = true,
                            LastName = "Williams"
                        },
                        new
                        {
                            Id = 5,
                            Address = "654 Birch Ave",
                            Email = "charlie.brown@example.com",
                            FirstName = "Charlie",
                            IsActive = true,
                            LastName = "Brown"
                        });
                });

            modelBuilder.Entity("LoncotesLibrary.Models.Checkout", b =>
                {
                    b.HasOne("LoncotesLibrary.Models.Material", "Material")
                        .WithMany("Checkouts")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoncotesLibrary.Models.Patron", "Patron")
                        .WithMany("Checkouts")
                        .HasForeignKey("PatronId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");

                    b.Navigation("Patron");
                });

            modelBuilder.Entity("LoncotesLibrary.Models.Material", b =>
                {
                    b.HasOne("LoncotesLibrary.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoncotesLibrary.Models.MaterialType", "MaterialType")
                        .WithMany()
                        .HasForeignKey("MaterialTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("MaterialType");
                });

            modelBuilder.Entity("LoncotesLibrary.Models.Material", b =>
                {
                    b.Navigation("Checkouts");
                });

            modelBuilder.Entity("LoncotesLibrary.Models.Patron", b =>
                {
                    b.Navigation("Checkouts");
                });
#pragma warning restore 612, 618
        }
    }
}
