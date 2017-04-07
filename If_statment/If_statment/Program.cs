using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_statment
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int myVar = 8;
            if (myVar == 10)
                Console.WriteLine("myvariable equal 10");
            else Console.WriteLine("my variable not equal 10");
*/

            int myvar1 = 10, myvar2 = 5, myvar3=9;
            bool myresult = (myvar1 <= 11) || (myvar2 == 6) && (myvar3 >= 8);
           
                Console.WriteLine("my results {0}", myresult);
            
            Console.ReadKey();

        }
    }
}
