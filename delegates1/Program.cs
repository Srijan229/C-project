namespace delegates1;
using System;
using System.Collections.Generic;
    class Ships
    {
        public delegate void Delegate1(string m);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int,int> cal = (a, b) => a + b;
            Console.WriteLine("The sum of all Ships is " + cal(10, 5));

            Func<string> Print = () => "The Ships are a combination of Starships and Battleships";
            Console.WriteLine(Print());

            Action<int, int> printSum = (a, b) => Console.WriteLine("Sum of Ships is : " + (a + b));
            printSum(6, 5);

            List<int> EvenRes = new List<int>() { 121, 124, 190, 134 };
            Predicate<int> Result = (EvenResNew) => EvenResNew > 130;
            List<int> Pres = EvenRes.FindAll(Result);

            Console.WriteLine("Numbers of ships is greater than 130:");
            foreach (int i in Pres)
            {
                Console.WriteLine(i);
            }
        }
    }


