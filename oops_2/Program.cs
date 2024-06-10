using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //laptop L1 = new laptop();
            //L1.colour = "black";
            //L1.model = "hp";
            //L1.year = 2021;

            //Console.WriteLine(L1);
            //L1.laptop_on();

            //laptop L2 = new laptop();
            //L2.colour = "metal";
            //L2.model = "hp";
            //L2.year = 2021;

            //Console.WriteLine(L2);
            //L2.laptop_off();


            //food f1 = new food();
            //f1.hotel = "hakkim";
            //f1.dish = "idly";
            //f1.price = 30;

            //Console.WriteLine(f1);
            //f1.dinein();

            //food f2 = new food();
            //f2.hotel = "kannappa";
            //f2.dish = "idly";
            //f2.price = 50;

            //Console.WriteLine(f2);
            //f2.takeaway();



            student s1 = new student();
            s1.name = "imran";
            s1.std = "fiveth";
            s1.roll_no = 2123;

            Console.WriteLine(s1);
            s1.presnt();


            student s2 = new student();
            s2.name = "krishna";
            s2.std = "fiveth";
            s2.roll_no = 2124;

            Console.WriteLine(s2);
            s2.absent();


        }
    }
}
