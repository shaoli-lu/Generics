using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class GroupJoin
    {
        Person magnus = new ("Magnus", "Hedlund" );
        Person terry = new("Terry", "Adams");
        Person charlotte = new("Charlotte", "Weiss");
        Person arlene = new("Arlene", "Huff");

        public void GetGroup() {
            //var peoples = new List<Person>();
            List<Person> people = new() { magnus, terry, charlotte, arlene };

            var pets = new List<Pet>()
            {
                new("Barley", terry),
                new("Boots", terry),
                new("Whiskers", charlotte),
                new("Blue Moon", terry),
                new("Daisy", magnus),
            };

            // Create a list where each element is an anonymous type
            // that contains the person's first name and a collection of
            // pets that are owned by them.
            var query =
                from person in people
                join pet in pets on person equals pet.Owner into gj
                select new
                {
                    OwnerName = person.FirstName,
                    Pets = gj
                };
            Console.WriteLine();
            Console.WriteLine(  "Linq SQL style Group Join");
            foreach (var v in query)
            {
                // Output the owner's name.
                Console.WriteLine($"{v.OwnerName}:");

                // Output each of the owner's pet's names.
                foreach (var pet in v.Pets)
                {
                    Console.WriteLine($"  {pet.Name}");
                }
            }

            //GroupJoin Extension method
            //var names = people.GroupJoin(pets, a => a, b => b.Owner, (a, b) => new { g1 = a, g2 = b }).SelectMany(x=>x.g2.DefaultIfEmpty(), (x, y) => new {x.g1, y}).Where(x=> x.y == null).Select(x=> x.g1).ToList();
            var names = people.GroupJoin(pets, a => a, b => b.Owner, (a, b) => new { g1 = a, g2 = b }).SelectMany(x => x.g2.DefaultIfEmpty(), (x, y) => new { x.g1, x.g2 }).ToList();
            Console.WriteLine();
            Console.WriteLine("Linq Ext method style Group Join");
            foreach (var v in names)
            {
                // Output the owner's name.
                Console.WriteLine($"{v.g1.FirstName}:");

                // Output each of the owner's pet's names.
                foreach (var pet in v.g2)
                {
                    Console.WriteLine($"  {pet.Name}");
                }
            }

        }


        /* Output:
             Magnus:
               Daisy
             Terry:
               Barley
               Boots
               Blue Moon
             Charlotte:
               Whiskers
             Arlene:
         */
    }
}
