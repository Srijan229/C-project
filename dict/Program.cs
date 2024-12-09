namespace dict;
using System;
using System.Collections.Generic;

class Product
{
    Dictionary<int, List<string>> cart = new Dictionary<int, List<string>>();

    public void Add()
    {
        Console.WriteLine("Enter the Product ID, product name, and product price:");
        int productId = Convert.ToInt32(Console.ReadLine());
        string productName = Console.ReadLine();
        int price = Convert.ToInt32(Console.ReadLine());

        // Add the product to the cart
        cart[productId] = new List<string> { productName, price.ToString() };
        Console.WriteLine($"Product '{productName}' added to the cart.");
    }

    public void Remove()
    {
        Console.WriteLine("Enter the Product ID to remove:");
        int productId = Convert.ToInt32(Console.ReadLine());

        if (cart.ContainsKey(productId))
        {
            List<string> removedProduct = cart[productId];
            Console.WriteLine($"Product removed: {removedProduct[0]} (Price: {removedProduct[1]})");
            cart.Remove(productId);
        }
        else
        {
            Console.WriteLine("Product not found in the cart.");
        }
    }

    public void DisplayCart()
    {
        Console.WriteLine("\nCart Contents:");
        foreach (var kvp in cart)
        {
            Console.WriteLine($"Product ID: {kvp.Key}, Name: {kvp.Value[0]}, Price: {kvp.Value[1]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Product obj = new Product();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add product to cart");
            Console.WriteLine("2. Remove product from cart");
            Console.WriteLine("3. Display cart contents");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string n = Console.ReadLine();

            switch (n)
            {
                case "1":
                    obj.Add();
                    break;
                case "2":
                    obj.Remove();
                    break;
                case "3":
                    obj.DisplayCart();
                    break;
                case "4":
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
