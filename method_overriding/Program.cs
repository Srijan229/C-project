namespace method_overriding;

using System;

class GalacticPlanetaryUnion
{
    public virtual void DisplayStatus(string planetName)
    {
        Console.WriteLine($"Planet {planetName} is a member of the Galactic Planetary Union.");
    }
}

class DefensePlanet : GalacticPlanetaryUnion
{
    public override void DisplayStatus(string planetName)
    {
        Console.WriteLine($"Planet {planetName} has a strong defense system in place.");
    }
}

class PeacefulPlanet : GalacticPlanetaryUnion
{
    public override void DisplayStatus(string planetName)
    {
        Console.WriteLine($"Planet {planetName} is known for its peaceful coexistence.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        GalacticPlanetaryUnion basePlanet = new GalacticPlanetaryUnion();
        DefensePlanet defendedPlanet = new DefensePlanet();
        PeacefulPlanet peacefulPlanet = new PeacefulPlanet();

        basePlanet.DisplayStatus("Earth");
        defendedPlanet.DisplayStatus("Mars");
        peacefulPlanet.DisplayStatus("Venus");
        Console.ReadKey();

    }
}
