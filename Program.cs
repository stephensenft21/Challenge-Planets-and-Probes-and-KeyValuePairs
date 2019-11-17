using System;
using System.Collections.Generic;
namespace PlanetsProbes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

            List<KeyValuePair<string, string>> probeDestinations = new List<KeyValuePair<string, string>>();
            probeDestinations.Add(new KeyValuePair<string, string>("HEll 3", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Kings ship 1", "Saturn"));
            probeDestinations.Add(new KeyValuePair<string, string>("Kings ship 2", "Jupiter"));
            probeDestinations.Add(new KeyValuePair<string, string>("Kings ship 3", "Venus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Kings ship 4", "Neptune"));
            probeDestinations.Add(new KeyValuePair<string, string>("Kings ship 5", "Uranus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Kings ship 6", "Earth"));
            probeDestinations.Add(new KeyValuePair<string, string>("Kings ship 7", "Mercury"));

            foreach (string planet in planetList)
            {
                // List to store probes that visited the planet
                List<string> matchingProbes = new List<string>();

                // Iterate probeDestinations
                foreach (KeyValuePair<string, string> probe in probeDestinations)
                {

                    if (planet == probe.Value)
                    {
                        matchingProbes.Add(probe.Key);
                    }

                    if (matchingProbes.Count != 0)
                    {
                        Console.WriteLine($"{planet}:{String.Join(",",matchingProbes)}");

                    }
                    /*
                        Does the current probe's destination
                        match the value of the `planet` variable?
                        If so, add it to the list.
                    */
                }

                /*
                    Use String.Join(",", matchingProbes) as part of the
                    solution to get the output below. It's the C# way of
                    writing `array.join(",")` in JavaScript.
                */

            }
        }
    }
}