using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterX = 0;

            Console.WriteLine("How many lines of Xs would you like?");
            string userX = Console.ReadLine();
            int numX = int.Parse(userX);

            int numY = 0;

            while (counterX < numX)
            {
                int counterY = 0;

                while (counterY <= numY)
                {
                    Console.Write("x");
                    counterY++;
                }

                Console.WriteLine();
                counterX++;
                numY++;
            }

            Console.WriteLine();

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
