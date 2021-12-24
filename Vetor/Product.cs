using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSeis
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double priceExternal)
        {
            Name = name;
            Price = priceExternal;
        }         
    }
}