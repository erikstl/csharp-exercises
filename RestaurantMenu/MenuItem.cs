using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class MenuItem
    {
        private string name;
        private decimal price;
        private List<string> description;
        private Dictionary<int, string> category;
        private readonly DateTime created;

        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public List<string> Description { get; private set; }
        public Dictionary<int, string> Category { get; private set; }
        public DateTime Created { get; }
    }
}
