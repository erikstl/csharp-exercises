using System;
using System.Collections.Generic;


namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Item name: ");
            string name = Console.ReadLine();

            Console.Write("Item price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            //decimal price = Convert.ToDecimal(priceString);

            Console.Write("Item description: ");
            string description = Console.ReadLine();

            Console.Write("Item category: ");
            string category = Console.ReadLine();

            MenuItem item = new MenuItem(name, price, description, category);

            Console.WriteLine(item);
            Console.ReadLine();
        }

    }
}