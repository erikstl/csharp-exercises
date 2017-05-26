using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class MenuItem
    {
        private string name;
        private decimal price;
        private string description;
        private string category;
        private readonly DateTime created;

        public string Name {
            get {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                this.price = value;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }
            private set
            {
                this.description = value;
            }
        }
        
        public string Category
        {
            get
            {
                return this.category;
            }
            private set
            {
                this.category = value;
            }
        }
        
        public DateTime Created
        {
            get
            {
                return this.created;
            }
        }
        

        public MenuItem(string name, decimal price, string description, string category)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.category = category;
            this.created = DateTime.Now;
        }

        public override String ToString()
        {
            return this.name + this.IsNew() + "\nPrice: " + this.price + "\nDescription: " + this.category +
                "\nAdded: " + this.created;
        }

        public string IsNew()
        {
            if((this.created - DateTime.Now).TotalDays < 30)
            {
                return "(New!)";
            }
            return "";
        }
    }
}
