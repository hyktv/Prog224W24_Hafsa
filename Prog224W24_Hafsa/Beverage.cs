using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog224W24_Hafsa
{
    public class Beverage : Product
    {
        //property
        public string Size { get; set; }

        //overide string
        public override string GetProductType()
        {
            return "Beverage";
        }

    }
}
