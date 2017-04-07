using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchStatement
{
    class Program
    {
        static void Main(string[] args)
        {

           /*  String myAnimal = "cat";
             switch (myAnimal)
             {
                 case "canary":
                     Console.WriteLine("my animal is the canary birs");
                     break;
                 case "cat":
                     Console.WriteLine("my animal is a cat");
                     break;
                 case "camel":
                     Console.WriteLine("my animal is a camel");
                     break;
             }
             Console.ReadKey();
             
            */


            int myvar = 20;
            switch (myvar)
            {
                case 15:
                    Console.WriteLine("my var is 15");
                    break;
                case 10:
                    Console.WriteLine("my var is 10");
                    break;
                default:
                    Console.WriteLine("no one");
                    break;
            }
            Console.ReadKey();
        }
    }
}
