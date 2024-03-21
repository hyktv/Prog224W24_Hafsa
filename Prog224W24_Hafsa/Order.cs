using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog224W24_Hafsa
{
    public class Order
    {
        public List<Product> Products { get; } = new List<Product>();

        //property
        public double TotalPrice { get; private set; }

        //constructor
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        //methofd
        public double CalculateTotalPrice()
        {
            TotalPrice = 0;
            foreach (var product in Products)
            {
                TotalPrice += product.Price;
            }
            return TotalPrice;
        }
    }
}
