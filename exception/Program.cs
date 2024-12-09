namespace exception;
using System;

using System;

public class PlanetaryException : Exception
{
    public PlanetaryException() { }

    public PlanetaryException(string message) : base(message) { }

    public PlanetaryException(string message, Exception inner) : base(message, inner) { }
}

public class PlanetaryGalacticUnion
{
    public string Name { get; set; }
    public int NumberOfPlanets { get; set; }

    public void AddPlanet(string planetName)
    {
        if (string.IsNullOrWhiteSpace(planetName))
        {
            throw new PlanetaryException("Planet name cannot be empty or null.");
        }
        // Code to add the planet
        Console.WriteLine($"Planet {planetName} added successfully.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            PlanetaryGalacticUnion union = new PlanetaryGalacticUnion();
            union.AddPlanet(""); // This will throw the custom exception
        }
        catch (PlanetaryException ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        Console.ReadKey();
    }
}
