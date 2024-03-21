using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog224W24_Hafsa
{
    public class Receipt
    {
        //properties
        public Order Order { get; set; }
        public double TotalPrice { get; set; }

        //overide string method
        public override string ToString()
        {
            string productsInfo = "";
            foreach (var product in Order.Products)
            {
                productsInfo += $"{product}\n";
            }
            return $"Order:\n{productsInfo}Total Price: ${TotalPrice}";
        }


    }
}
