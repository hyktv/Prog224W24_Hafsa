using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog224W24_Hafsa
{
    public abstract class Product
    {
        //properties
        public string Name { get; set; }
        public double Price { get; set; }

        //methods/overide string
        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price:C}";
        }

        public abstract string GetProductType();
    }
}
