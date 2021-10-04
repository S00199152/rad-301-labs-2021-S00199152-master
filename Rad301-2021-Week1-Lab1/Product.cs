using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad301_2021_Week1_Lab1
{
    public class Product
    {
        public int ProductID { get; set; }

        public string Description { get; set; }

        public int QuantityInStock { get; set; }

        public float UnitPrice { get; set; }

        public int CategoryID { get; set; }

        public override string ToString()
        {
            return String.Concat("Product", Description);
        }
    }
}
