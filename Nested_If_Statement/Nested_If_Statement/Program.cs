using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int myvar1 =9, myvar2 = 6;
            if (myvar1 == 9)
            {
                Console.WriteLine("myvar1==9");
                if (myvar2 == 7)
                {
                    Console.WriteLine("myvar2==7");
                }
                else
                {
                    Console.WriteLine("myvar2 not equal 7 ");
                }
            }
            else
            {
                Console.WriteLine("myvar1 not equal 9");
            }
            Console.ReadKey();
        }
    }
}
