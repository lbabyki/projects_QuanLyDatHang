using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modelss
{
    internal class Order
    {
        public int OrderId { get; set; }
        public ProductType ProductType { get; set; }
        public string OrderMode { get; set; } // Legacy | Modern
    }
}
}
