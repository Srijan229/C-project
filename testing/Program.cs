namespace testing;
using System;
class Temple
{
    public string Name { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public Temple()
    {
        Name = null;
        Height = 50;
        Width = 30;
    }
    public void CalculateArea()
    {
        try
        {
            if (Height <= 0 || Width <= 0)
            {
                throw new InvalidOperationException("Height and Width must be greater than zero.");
            }
            double area = Height * Width * 0.5;
            Console.WriteLine($"The area of the temple is: {area} sq. meter");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
    public void PrintTempleInfo()
    {
        try
        {
            int n = 0;
            int r = 5 / n;
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Temple temple = new Temple();
        temple.CalculateArea();
        temple.PrintTempleInfo();
        Console.ReadKey();
    }
}