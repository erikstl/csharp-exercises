using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Menu
    {
        private DateTime menuUpdate;
        private List<MenuItem> food;

        public DateTime MenuUpdate
        {
            get
            {
                return this.menuUpdate;
            }
            private set
            {
                this.menuUpdate = value;
            }
        }

        public List<MenuItem> Food
        {
            get
            {
                return this.food;
            }
            private set
            {
                this.food = value;
            }
        }
        
        public Menu(List<MenuItem> food)
        {
            this.food = food;
            this.menuUpdate = DateTime.Now;
        }

        public void PrintMenu()
        {
            foreach(MenuItem item in this.food)
            {
                Console.WriteLine(item);
            }
        }

        public void AddItem(MenuItem item)
        {
            this.food.Add(item);
        }
    }
}
