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

            // declare the spacecrafts
            // key is craft's name, value is a List of planets (strings)
            var spacecrafts = new Dictionary<string, List<string>>()
            {
                {"Messenger", new List<string>() {"Mercury", "Venus"} },
                {"Venus Express", new List<string>() {"Venus"} },
                {"2001 Mars Odyssey", new List<string>() {"Mars"} },
                {"Phoenix", new List<string>() {"Mars"} },
                {"Juno", new List<string>() {"Jupiter"} },
                {"Ulysses", new List<string>() {"Jupiter"} },
                {"Pioneer 11", new List<string>() {"Jupiter, Saturn"} },
                {"Voyager 2", new List<string>() {"Jupiter", "Saturn", "Uranus", "Neptune"} },
                {"New Horizons", new List<string>() {"Pluto"} }
            };

            foreach (var planet in planetList)
            {
                var planetVisitedBy = new List<string>();
                foreach (var spacecraft in spacecrafts)
                {
                    if (spacecraft.Value.Contains(planet))
                    {
                        planetVisitedBy.Add(spacecraft.Key);
                    }
                }
                var spacecraftList = string.Join(", ", planetVisitedBy);

                Console.WriteLine($"{planet}: {spacecraftList}");
            }


        }
    }
}
