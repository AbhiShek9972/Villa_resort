using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Villa_resort.Domain.Entities;

namespace Villa_resort.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<VillaModel> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // base.OnModelCreating(modelBuilder);
          base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<VillaModel>().HasData(
                new VillaModel
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Description = "A luxurious villa with royal amenities.",
                    Occupancy = 4,
                    Price = 250.00,
                    Sqft = 1500,
                    ImageUrl = "https://example.com/images/royal_villa.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new VillaModel
                {
                    Id = 2,
                    Name = "Beachfront Villa",
                    Description = "A beautiful villa located right on the beach.",
                    Occupancy = 6,
                    Price = 300.00,
                    Sqft = 1800,
                    ImageUrl = "https://example.com/images/beachfront_villa.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                }
            );
        }
    }
}
