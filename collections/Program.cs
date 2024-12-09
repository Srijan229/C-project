namespace collections;
using System.Collections;
using System;

class Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array to store planets (example, not used in List operations)
            string[] planetArray = new string[3];

            // List to manage planets in the union
            List<string> planets = new List<string>();
            planets.Add("Earth");
            planets.Add("Mars");
            planets.Add("Jupiter");
            planets.Insert(1, "Venus");
            planets.RemoveAt(0);
            planets.RemoveRange(1, 2);

            foreach(string planet in planets)
            {
                Console.WriteLine($"Planet in union: {planet}");
            }

            Console.WriteLine($"Total planets in union: {planets.Count}");
            Console.ReadKey();
        }
    }
}
