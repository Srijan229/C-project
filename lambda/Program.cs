namespace lambda;
using System;
using System.Collections.Generic;
using System.Linq;

class Planet
{
    public int PlanetId { get; set; }
    public string PlanetName { get; set; }
    public string Sector { get; set; }

    public Planet(int planetId, string planetName, string sector)
    {
        PlanetId = planetId;
        PlanetName = planetName;
        Sector = sector;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Planet> planetList = new List<Planet>
        {
            new Planet(301, "Earth", "Alpha"),
            new Planet(302, "Mars", "Alpha"),
            new Planet(303, "Venus", "Beta"),
            new Planet(304, "Jupiter", "Beta"),
            new Planet(305, "Saturn", "Gamma")
        };

        var filteredPlanets = planetList.Where(planet => planet.Sector == "Alpha");
        Console.WriteLine("Planets in Alpha Sector");
        foreach (Planet planet in filteredPlanets)
        {
            Console.WriteLine($"Planet ID: {planet.PlanetId}\nPlanet Name: {planet.PlanetName}");
        }

        var orderedPlanets = planetList.OrderBy(planet => planet.PlanetName);
        Console.WriteLine("Planets Ordered by Name");
        foreach (Planet planet in orderedPlanets)
        {
            Console.WriteLine(planet.PlanetName);
        }

        var groupedPlanets = planetList.GroupBy(planet => planet.Sector);
        Console.WriteLine("Planets Grouped by Sector");
        foreach (var group in groupedPlanets)
        {
            Console.WriteLine($"Sector: {group.Key}");
            foreach (var planet in group)
            {
                Console.WriteLine(planet.PlanetName);
            }
        }
    }
}
 