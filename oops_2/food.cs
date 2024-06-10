using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace oops_2
{
    class food
    {
        public string hotel;
        public string dish;
        public int price;

        public void dinein()
    {
        Console.WriteLine("dinein");
    }
        public void takeaway()
        {
            Console.WriteLine("takeaway");
        }
        public override string ToString()
        {
            return hotel + "-" + dish + "-" + "-" + price;
        }



    }
}
