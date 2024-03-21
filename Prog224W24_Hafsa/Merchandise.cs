using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog224W24_Hafsa
{
    public class Merchandise : Product
    {
        //property
        public string Category { get; set; }

        //overide string
        public override string GetProductType()
        {
            return "Merchandise";
        }
    }
}
