using System;
using System.Collections;

namespace interface_1;
interface IAdd
{
    void AddFunction();
}

interface IRemove
{
    void RemoveFunction();
}

class PlanetManager : IAdd, IRemove
{
    private List<string> planetList = new List<string>();

    public void AddFunction()
    {
        Console.WriteLine("Enter the planet's name to add:");
        string planetName = Console.ReadLine();
        planetList.Add(planetName);
        Console.WriteLine($"{planetName} has been added to the planet list.");
    }

    public void RemoveFunction()
    {
        Console.WriteLine("Enter the planet's name to remove:");
        string planetName = Console.ReadLine();
        if (planetList.Remove(planetName))
        {
            Console.WriteLine($"{planetName} has been removed from the planet list.");
        }
        else
        {
            Console.WriteLine($"{planetName} not found in the list.");
        }
    }

    public void DisplayPlanetList()
    {
        Console.WriteLine("\nConfirmed Planet List:");
        if (planetList.Count == 0)
        {
            Console.WriteLine("No planets in the list.");
        }
        else
        {
            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }
        }
    }
}

class Program
{
    static int Main(string[] args)
    {
        PlanetManager planetManager = new PlanetManager();
        string choice;

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add planet");
            Console.WriteLine("2. Remove planet");
            Console.WriteLine("3. Display confirmed planet list");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    planetManager.AddFunction();
                    break;
                case "2":
                    planetManager.RemoveFunction();
                    break;
                case "3":
                    planetManager.DisplayPlanetList();
                    break;
                case "4":
                    Console.WriteLine("Exiting the program.");
                    return 0;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

