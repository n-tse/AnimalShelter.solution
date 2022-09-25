using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
      public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
          : base(options)
      {
      }
      
      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Animal>()
          .HasData(
              new Animal { AnimalId = 1, Name = "Matilda", Species = "Dog", Age = 7 },
              new Animal { AnimalId = 2, Name = "Rexie", Species = "Cat", Age = 10 },
              new Animal { AnimalId = 3, Name = "Matilda", Species = "Rabbit", Age = 2 },
              new Animal { AnimalId = 4, Name = "Pip", Species = "Bird", Age = 4 },
              new Animal { AnimalId = 5, Name = "Bartholomew", Species = "Guinea Pig", Age = 22 }
              new Animal { AnimalId = 6, Name = "Fido", Species = "Cat", Age = 12 },
              new Animal { AnimalId = 7, Name = "Abracadabraalakazam", Species = "Cat", Age = 8 }
              new Animal { AnimalId = 8, Name = "Bigfoot", Species = "Gecko", Age = 4 },
              new Animal { AnimalId = 9, Name = "Casper", Species = "Bird", Age = 9 },
              new Animal { AnimalId = 10, Name = "Leon", Species = "Rabbit", Age = 16 },
              new Animal { AnimalId = 11, Name = "Coco", Species = "Dog", Age = 13 },
              new Animal { AnimalId = 12, Name = "Scout", Species = "Cat", Age = 6 }
      }

      public DbSet<Animal> Animals { get; set; }
    }
}