using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {

            // declare planetList
            var planetList = new List<string>() { "Mercury", "Mars" };

            // add Jupiter and Saturn to the list
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            // declare a new planet list because why not
            var planetList2 = new List<string>() { "Uranus", "Neptune" };

            // add the new planet list to the first planet list
            planetList.AddRange(planetList2);

            // place items in specific places in the list
            // Earth goes in spot 1 rather than 2 becuase venus
            // isn't added until after
            // it gets shifted to index 2 when venus gets added
            // to index 1
            planetList.Insert(1, "Earth");
            planetList.Insert(1, "Venus");

            // add the best planet
            planetList.Add("Pluto");

            // let's make sure it's right
            foreach (var planet in planetList)
            {
                Console.WriteLine($"{planet}");
            }

            // separate things
            Console.WriteLine(new string('-', 50));

            // make a new list for rocky planets
            // aka the first 4
            var rockyPlanets = planetList.GetRange(0, 4);

            // make sure it's right
            foreach (var planet in rockyPlanets)
            {
                Console.WriteLine($"{planet}");
            }

            // separate things
            Console.WriteLine(new string('-', 50));

            // remove the best planet, lame
            planetList.Remove("Pluto");
        }
    }
}
