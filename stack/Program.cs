namespace stack;
using System;
using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> planets = new Stack<string>();
            bool continueProgram = true;

            while (continueProgram)
            {
                Console.WriteLine("\nGalactic Planetary Union - Stack Operations");
                Console.WriteLine("1. Push (Add a planet)");
                Console.WriteLine("2. Pop (Remove the top planet)");
                Console.WriteLine("3. Display (Show all planets in the stack)");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the name of the planet to push: ");
                        string planet = Console.ReadLine();
                        planets.Push(planet);
                        Console.WriteLine($"{planet} has been added to the stack.");
                        break;

                    case "2":
                        if (planets.Count > 0)
                        {
                            string removedPlanet = planets.Pop();
                            Console.WriteLine($"{removedPlanet} has been removed from the stack.");
                        }
                        else
                        {
                            Console.WriteLine("The stack is empty, no planet to remove.");
                        }
                        break;

                    case "3":
                        if (planets.Count > 0)
                        {
                            Console.WriteLine("Planets in the stack:");
                            foreach (string p in planets)
                            {
                                Console.WriteLine(p);
                            }
                        }
                        else
                        {
                            Console.WriteLine("The stack is empty.");
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

