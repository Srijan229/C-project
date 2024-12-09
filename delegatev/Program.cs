using System;

namespace delegatev;

class Message
    {
        public delegate void Delegate1(int a, int b);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Battleships and Starships");

            // Parse input to integers
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Message.Delegate1 del1;

            if (a < b)
            {
                del1 = (x, y) => Console.WriteLine($"The Planet member needs {y - x} Battleships");
            }
            else
            {
                del1 = (x, y) => Console.WriteLine($"The Planet member needs {x - y} Starships");
            }
            del1(a, b);
            Console.ReadLine();
        }
    }