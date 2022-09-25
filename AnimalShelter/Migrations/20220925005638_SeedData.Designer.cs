﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    [Migration("20220925005638_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 7,
                            Name = "Matilda",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 10,
                            Name = "Rexie",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 2,
                            Name = "Matilda",
                            Species = "Rabbit"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 4,
                            Name = "Pip",
                            Species = "Bird"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 22,
                            Name = "Bartholomew",
                            Species = "Guinea Pig"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
