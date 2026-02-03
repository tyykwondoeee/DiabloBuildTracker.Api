using DiabloBuildTracker.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Data.Seed
{
    public static class ClassSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            //Classes
            modelBuilder.Entity<Class>().HasData(
                new Class
                {
                    Id = 1,
                    Name = "Barbarian"
                }
                );

            modelBuilder.Entity<Class>().HasData(
                new Class
                {
                    Id = 2,
                    Name = "Druid"
                }
                );

            modelBuilder.Entity<Class>().HasData(
                new Class
                {
                    Id = 3,
                    Name = "Necromancer"
                }
                );

            modelBuilder.Entity<Class>().HasData(
                new Class
                {
                    Id = 4,
                    Name = "Rogue"
                }
                );

            modelBuilder.Entity<Class>().HasData(
                new Class
                {
                    Id = 5,
                    Name = "Sorcerer"
                }
                );

            modelBuilder.Entity<Class>().HasData(
                new Class
                {
                    Id = 6,
                    Name = "Sprirtborn"
                }
                );

            modelBuilder.Entity<Class>().HasData(
                new Class
                {
                    Id = 7,
                    Name = "Paladin"
                }
                );
        }
    }
}
