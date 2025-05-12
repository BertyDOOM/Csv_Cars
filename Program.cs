using CsvHelper;
using CsvHelper.Configuration.Attributes;
using System.Globalization;
using System.Reflection;
using System.Xml.Linq;

namespace Csv_Cars 
{

 //Properties > Copy Awlays за файла с работи
 //ExcelDataReader и/или CsvHelper Nuget-и
    class Program 
    {
        static void Main(string[] args) 
        {
            List<Car> seedCars = new List<Car>();
            var getCars = Car.ReadCsvCars("cars specifications.csv");
            seedCars.AddRange(getCars);
            foreach (var obj in seedCars)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} |{9}| |{10}|",obj.Id, obj.mpg, obj.cylinders,
                obj.displacement, obj.horsepower, obj.weight, obj.acceleration, obj.modelYear, obj.origin, obj.carBrand, obj.carModel);
            }
        }
    }
}
