using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog224W24_Hafsa
{
    public class Food : Product
    {
        //property
        public string ExpirationDate { get; set; }

        //overide string
        public override string GetProductType()
        {
            return "Food";
        }
    }
}
