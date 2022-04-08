using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>() {
new Car() { VIN ="A1", Make= "BMW", Model= "550i", StickerPrice=55000, Year=2012},
new Car() { VIN ="B2", Make= "Toyota", Model= "4Runner", StickerPrice=35000, Year=2011},
new Car() { VIN ="C3", Make= "BMW", Model= "745li", StickerPrice=75000, Year=2021},
new Car() { VIN ="D4", Make= "Ford", Model= "Escape", StickerPrice=25000, Year=2004},
new Car() { VIN ="E5", Make= "BMW", Model= "55i", StickerPrice=57000, Year=2022}
            };

            // query
            //var bmws = from car in cars
            //           where car.Make == "BMW"
            //           && car.Year == 2012
            //           select car;
            var bmws = from car in cars
                       where car.Make == "BMW"
                       //&& car.Year == 2012
                       orderby car.Year descending
                       select new
                       {
                           car.Make,
                           car.Model,
                           car.Year
                       };
            
            Console.WriteLine(  "--LINQ Query approach");
            foreach (var car in bmws)
            {
                Console.WriteLine("{0} {1} {2}", car.Year, car.Make, car.Model);
            }

            // ext method
            //var bmws2 = cars.Where(p => p.Make == "BMW" && p.Year == 2012);
            var bmws2 = cars.Where(p => p.Make == "BMW").OrderByDescending(t => t.Year);
            Console.WriteLine();
            Console.WriteLine("--LINQ Extension Method approach");
            foreach (Car car in bmws2)
            {
                Console.WriteLine("{0} {1} {2}", car.Year, car.Make, car.VIN);
            }
            Console.WriteLine();
            Console.WriteLine(  "--ForEach");
            cars.ForEach(p => p.StickerPrice -= 10000);
            cars.ForEach(car => Console.WriteLine("{0} {1} {2} {3} {4}", car.Year, car.VIN, car.Make, car.Model, car.StickerPrice));
            Console.WriteLine();
            Console.WriteLine(  "--Exists");
            Console.WriteLine(  cars.Exists(p => p.Model=="745li"));
            Console.WriteLine();
            Console.WriteLine("--TrueForAll");
            Console.WriteLine(cars.TrueForAll(p => p.Year >1999));
            Console.WriteLine();
            Console.WriteLine("--Sum");
            Console.WriteLine("{0:C2}",cars.Sum(p => p.StickerPrice));
            Console.WriteLine();
            Console.WriteLine("--GetType");
            Console.WriteLine(cars.GetType());
            Console.WriteLine();
            Console.WriteLine("--First");
            Console.WriteLine(cars.OrderByDescending(p=>p.Year).Select(p=> new {p.Make, p.Year,p.Model}).First(p=>p.Make=="BMW").ToString());
            Console.ReadLine();
        }
    }
}
