namespace queue;

using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> planets = new Queue<string>();
            bool continueProgram = true;

            while (continueProgram)
            {
                Console.WriteLine("\nGalactic Planetary Union - Queue Operations");
                Console.WriteLine("1. Enqueue (Add a planet)");
                Console.WriteLine("2. Dequeue (Remove the first planet)");
                Console.WriteLine("3. Display (Show all planets in the queue)");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the name of the planet to enqueue: ");
                        string planet = Console.ReadLine();
                        planets.Enqueue(planet);
                        Console.WriteLine($"{planet} has been added to the queue.");
                        break;

                    case "2":
                        if (planets.Count > 0)
                        {
                            string removedPlanet = planets.Dequeue();
                            Console.WriteLine($"{removedPlanet} has been removed from the queue.");
                        }
                        else
                        {
                            Console.WriteLine("The queue is empty, no planet to remove.");
                        }
                        break;

                    case "3":
                        if (planets.Count > 0)
                        {
                            Console.WriteLine("Planets in the queue:");
                            foreach (string p in planets)
                            {
                                Console.WriteLine(p);
                            }
                        }
                        else
                        {
                            Console.WriteLine("The queue is empty.");
                        }
                        break;

                    case "4":
                        continueProgram = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }

