﻿using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category {Id = 1,Name = "Action",DisplayOrder = 1 },
                new Category {Id = 2,Name = "Scifi",DisplayOrder = 2 },
                new Category {Id = 3,Name = "History",DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Fortune of Time",
                    Author = "Billy Spark",
                    Description = "A thrilling journey through the mysteries of time.",
                    ISBN = "SWD999001",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 2,
                    Title = "Mastering the Code",
                    Author = "Jane Doe",
                    Description = "Unlock the secrets of programming with practical examples.",
                    ISBN = "SWD999002",
                    ListPrice = 120,
                    Price = 110,
                    Price50 = 105,
                    Price100 = 100,
                    CategoryId = 1,
                    ImageUrl = ""

                },
                new Product
                {
                    Id = 3,
                    Title = "Cooking the Modern Way",
                    Author = "Chef Ramsey",
                    Description = "Delicious recipes with a contemporary twist.",
                    ISBN = "SWD999003",
                    ListPrice = 45,
                    Price = 40,
                    Price50 = 38,
                    Price100 = 35,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "Fitness for Life",
                    Author = "John Fit",
                    Description = "Your ultimate guide to a healthy and active lifestyle.",
                    ISBN = "SWD999004",
                    ListPrice = 60,
                    Price = 55,
                    Price50 = 50,
                    Price100 = 48,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "Art of Design",
                    Author = "Creative Mind",
                    Description = "Explore the beauty and functionality of modern design.",
                    ISBN = "SWD999005",
                    ListPrice = 80,
                    Price = 75,
                    Price50 = 70,
                    Price100 = 65,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "Space and Beyond",
                    Author = "Astro Nova",
                    Description = "A fascinating look into the wonders of the universe.",
                    ISBN = "SWD999006",
                    ListPrice = 150,
                    Price = 140,
                    Price50 = 135,
                    Price100 = 130,
                    CategoryId = 3,
                    ImageUrl = ""
                }
                );


        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
