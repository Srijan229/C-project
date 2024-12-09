namespace thread1;

using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Create and start three threads
        Thread thread1 = new Thread(new ThreadStart(ThreadMethod));
        Thread thread2 = new Thread(new ThreadStart(ThreadMethod));
        Thread thread3 = new Thread(new ThreadStart(ThreadMethod));

        thread1.Start();
        thread2.Start();
        thread3.Start();

        // Main thread work
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Main thread: " + i);
            Thread.Sleep(1000); // Sleep for 1 second
        }

        // Wait for all threads to complete
        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine("All threads have completed. Press any key to exit.");
        Console.ReadKey();
    }

    static void ThreadMethod()
    {
        // Each thread prints its own sequence of numbers
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Worker thread: " + Thread.CurrentThread.ManagedThreadId + " - " + i);
            Thread.Sleep(1000); // Sleep for 1 second
        }
    }
}
