using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Menu
    {
        private DateTime menuUpdate;
        private List<MenuItem> food;

        public DateTime MenuUpdate { get; private set; }
        public List<MenuItem> Food { get; private set; }

    }
}
