using CsvHelper;
using CsvHelper.Configuration.Attributes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//mpg,cylinders,displacement,horsepower,weight,acceleration,model year,origin,car name

namespace Csv_Cars
{
    class Car
    {
        [Ignore]public int Id { get; set; }
        public decimal mpg {  get; set; }
        public decimal cylinders { get; set; }
        public decimal displacement { get; set; }
        public string horsepower { get; set; }
        public decimal weight { get; set; }
        public decimal acceleration { get; set; }
        [Name("model year")] public int modelYear{ get; set; }
        public int origin { get; set; }
        [Name("car name")] public string carBrand { get; set; }
        [Ignore]public string? carModel { get; set; } //IS NULL заради 2 субарута
        
        public static List<Car> ReadCsvCars(string file)
        {
            
            using var reader = new StreamReader(file);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var cars = csv.GetRecords<Car>().ToList();
            for (int i = 0; i < cars.Count; i++) 
            {
                cars[i].Id = i + 1;
                var split = cars[i].carBrand.Split(new[] { ' ' }, 2);
                cars[i].carBrand = split.ElementAtOrDefault(0);
                cars[i].carModel = split.ElementAtOrDefault(1);
            }
            return cars;
            // car model - car|Ford| model|Focus 1.4| one : many
            //Dicitionary за цепене на модел
            //    public void SaveToDb(){} вика се накрая веднъж
        }
    }
}
