namespace async;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Program
    {
        static async Task Main(string[] args)
        {
            Task task = MonitorPlanet();
            Console.WriteLine("Initiating communication with planetary base...");
            await task;
            Console.WriteLine("Communication established with planetary base.");
            Console.ReadKey();
        }

        static async Task MonitorPlanet()
        {
            Console.WriteLine("Scanning planetary surface...");
            await Task.Delay(3000);
            Console.WriteLine("Surface scan complete.");
        }
    }

