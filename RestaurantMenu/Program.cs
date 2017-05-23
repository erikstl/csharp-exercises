using System;
using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Menu
    {
        MenuItem item = new MenuItem();
        private DateTime lastUpdate;

        public DateTime LastUpdate
        {
            get { return lastUpdate; }
            set { lastUpdate = value; }
        }
    }

    public class MenuItem
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            private set { price = value; }
        }

        private string desc;

        public string Desc
        {
            get { return desc; }
            private set { desc = value; }
        }

        private string category;

        public string Category
        {
            get { return category; }
            private set { category = value; }
        }

        private bool newItem;

        public bool NewItem
        {
            get { return newItem; }
            private set { newItem = value; }
        }
    }
}