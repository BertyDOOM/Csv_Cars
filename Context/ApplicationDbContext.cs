using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Csv_Cars.Seeder;
using Microsoft.Data.SqlClient;


namespace Csv_Cars.Context
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-7AG4V62;Database=CarCSV_Test;Trusted_Connection=true;TrustServerCertificate=true");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            Csv_Cars.Seeder.Seeder s = new Csv_Cars.Seeder.Seeder();
            s.Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
