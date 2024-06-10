using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops_2
{
    class laptop
    {
        public string colour;
        public string model;
        public int year;

        public void laptop_on()
        {
            Console.WriteLine("laptop_on");
        }
        public void laptop_off()
        {
            Console.WriteLine("laptop_off");
        }
        public override string ToString()
        {
            return model + "_" + year + "_" + colour;
        }
    }
}
