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
          );
      }

      public DbSet<Animal> Animals { get; set; }
    }
}