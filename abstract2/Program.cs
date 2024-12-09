namespace abstract2;

using System;
public class Program
{
    public static int operationCount;
    abstract class Operations
    {
        public abstract void PerformTask1(string target);
        public abstract void PerformTask2(string target);
        public abstract void CheckOperationStatus();
    }

    class Communication : Operations
    {
        public override void PerformTask1(string planetName)
        {
            Console.WriteLine($"Communication established with planet {planetName}");
            operationCount++;
        }

        public override void PerformTask2(string planetName)
        {
            Console.WriteLine($"Surface scan initiated on planet {planetName}");
            operationCount++;
        }

        public override void CheckOperationStatus()
        {
            if (operationCount > 0)
            {
                Console.WriteLine("Operations in progress");
            }
            else
            {
                Console.WriteLine("No operations performed");
            }
        }

        public Communication()
        {
            Console.WriteLine("Performing Communication Operations...");
            PerformTask1("Zeta-Prime");
            PerformTask2("Zeta-Prime");
            CheckOperationStatus();
        }
    }

    class Exploration : Operations
    {
        public override void PerformTask1(string planetName)
        {
            Console.WriteLine($"Probe deployed to planet {planetName}");
            operationCount++;
        }

        public override void PerformTask2(string planetName)
        {
            Console.WriteLine($"Data retrieved from probe on planet {planetName}");
            operationCount++;
        }

        public override void CheckOperationStatus()
        {
            if (operationCount > 0)
            {
                Console.WriteLine("Operations in progress");
            }
            else
            {
                Console.WriteLine("No operations performed");
            }
        }

        public Exploration()
        {
            Console.WriteLine("Performing Exploration Operations...");
            PerformTask1("Alpha-Centauri");
            PerformTask2("Alpha-Centauri");
            CheckOperationStatus();
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter 1 for Communication Operations \nEnter 2 for Exploration Operations");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Communication commObj = new Communication();
                break;
            case 2:
                Exploration explObj = new Exploration();
                break;
            default:
                Console.WriteLine("Invalid Entry");
                break;
        }
        Console.ReadKey();
    }
}








