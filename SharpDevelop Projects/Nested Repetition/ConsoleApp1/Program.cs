using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterX = 0;

            Console.WriteLine("How many lines of Xs would you like?");
            string userX = Console.ReadLine();
            int numX = int.Parse(userX);

            while (counterX < 5) {
                int counterY = 0;

                while (counterY <= numX) {
                    Console.Write("x");
                    counterY++;
                }

                Console.WriteLine();
                counterX++;
                numX++;
            }

            Console.WriteLine();

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
