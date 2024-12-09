using System;
using System.IO;

class Program
{
    const string FilePath = "planetary_union.txt";
    static int nextId = 11; 

    static void Main()
    {
        
        if (!File.Exists(FilePath))
        {
            
            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                sw.WriteLine("Planet Name\tUnion ID");
            }
        }

        
        Console.Write("Enter the planet name (or type 'list' to display all): ");
        string input = Console.ReadLine();

        if (input.Equals("list", StringComparison.OrdinalIgnoreCase))
        {
            DisplayAllPlanets();
        }
        else
        {
            
            AddPlanet(input);
        }

        Console.ReadKey();
    }

    static void AddPlanet(string planetName)
    {
        
        var lines = File.ReadAllLines(FilePath);
        foreach (var line in lines)
        {
            var parts = line.Split('\t');
            if (parts[0].Equals(planetName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"The planet {planetName} already exists with Union ID: {parts[1]}");
                return; 
            }
        }

        
        string newUnionId = $"PGU-{nextId+3:D3}";

        
        using (StreamWriter sw = new StreamWriter(FilePath, true))
        {
            sw.WriteLine($"{planetName}\t{newUnionId}");
        }

        Console.WriteLine($"Added {planetName} with Union ID: {newUnionId}");
        nextId++;
    }

    static void DisplayAllPlanets()
    {
        
        var lines = File.ReadAllLines(FilePath);
        Console.WriteLine("\nPlanetary Union List:");
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }
    }
}
