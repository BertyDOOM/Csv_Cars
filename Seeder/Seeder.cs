using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csv_Cars.Seeder
{
    class Seeder
    {
        public static List<Car> carsList = Car.ReadCsvCars("cars specifications.csv");
        public void Seed(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Car>().HasData(carsList.ToArray());
        }
    }
    
}
