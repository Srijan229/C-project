using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Welcome to the Planetary Galactic Union simulation!");

        
        Task earthTask = VisitPlanetAsync("Earth", 4000);
        Task saturnTask = VisitPlanetAsync("Kaylon_Primary", 5000);

         
        Console.WriteLine("Visiting planets asynchronously...");

         
        await Task.Delay(3000); 

         
        await earthTask;
        await saturnTask;

        Console.WriteLine("All planets visited! Simulation complete.");
    }

    static async Task VisitPlanetAsync(string planetName, int visitTimeMs)
    {
        await Task.Run(() =>
        {
            Console.WriteLine($"Visiting {planetName}...");
            Task.Delay(visitTimeMs).Wait();  
            Console.WriteLine($"Visited {planetName}.");
            Console.ReadKey();
        });
    }
}
