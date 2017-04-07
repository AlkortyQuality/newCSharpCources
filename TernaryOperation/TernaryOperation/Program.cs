using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperation
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
                 int myVar = 9;
                 string myresult = (myVar<10) ? "less than 10" : "greater than 10";
                 Console.WriteLine("my varialbl result {0}", myresult);

                 Console.ReadKey();

         */

            string myName = "ayman", result;
            result = (myName.Equals("Ayman")) ? "YES" : "NO";
            Console.WriteLine("my varialbl result {0}", result);

            Console.ReadKey();




        }
    }
}
