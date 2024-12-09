namespace methodoverloading;
using System;

class GalacticPlanetaryUnion
{
    public void DisplayStatus(string planetName)
    {
        Console.WriteLine($"Planet {planetName} is a member of the Galactic Planetary Union.");
    }

    public void DisplayStatus(string planetName, bool hasDefense)
    {
        if (hasDefense)
        {
            Console.WriteLine($"Planet {planetName} has a strong defense system in place.");
        }
        else
        {
            Console.WriteLine($"Planet {planetName} has no defense system.");
        }
    }

    public void DisplayStatus(string planetName, bool hasDefense, string preference)
    {
        string defenseStatus = hasDefense ? "has a strong defense system" : "has no defense system";
        Console.WriteLine($"Planet {planetName} {defenseStatus} and prefers {preference}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        GalacticPlanetaryUnion union = new GalacticPlanetaryUnion();

        union.DisplayStatus("Earth");
        union.DisplayStatus("Mars", true);
        union.DisplayStatus("Venus", false, "peaceful coexistence");
        Console.ReadKey();
    }
}
