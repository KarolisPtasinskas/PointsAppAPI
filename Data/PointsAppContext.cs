using Microsoft.EntityFrameworkCore;
using PointsAppWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointsAppWebAPI.Data
{
    public class PointsAppContext : DbContext
    {
        public DbSet<Coordinate> Coordinates { get; set; }
        public DbSet<CoordinatesList> CoordinatesLists { get; set; }

        public PointsAppContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoordinatesList>()
            .HasMany(p => p.Coordinates)
            .WithOne(t => t.CoordinatesList)
            .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
