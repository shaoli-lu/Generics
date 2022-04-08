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
new Car() { VIN ="C3", Make= "BMW", Model= "745li", StickerPrice=75000, Year=2012},
new Car() { VIN ="D4", Make= "Ford", Model= "Escape", StickerPrice=25000, Year=2004},
new Car() { VIN ="E5", Make= "BMW", Model= "55i", StickerPrice=57000, Year=2022}
            };

            // query
            var bmws = from car in cars
                       where car.Make == "BMW"
                       && car.Year == 2012
                       select car;
            Console.WriteLine(  "--LINQ Query approach");
            foreach (Car car in bmws)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }

            // ext method
            var bmws2 = cars.Where(p => p.Make == "BMW" && p.Year == 2012);
            Console.WriteLine();
            Console.WriteLine("--LINQ Extension Method approach");
            foreach (Car car in bmws2)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }
            Console.ReadLine();
        }
    }
}
