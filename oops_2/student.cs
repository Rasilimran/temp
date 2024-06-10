using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops_2
{
    class student
    {
        public string name;
        public string std;
        public int roll_no;

        public void presnt()
        {
            Console.WriteLine("present");
        }
        public void absent()
        {
            Console.WriteLine("absent");
        }
        public override string ToString()
        {
            return name + "-" + std + "-" + roll_no;
        }
    }
}
