using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            long myvar = 1000;
            float myvar2 = myvar;

            float myfloatvar = 12.5f;
            int myint2var = myfloatvar;

            //Console.WriteLine($"{myvar2}");

            char myvar3 = 'G';
            int myintvar = myvar3;

            Console.WriteLine($"{myintvar}");

            Console.ReadKey();


        }
    }
}
