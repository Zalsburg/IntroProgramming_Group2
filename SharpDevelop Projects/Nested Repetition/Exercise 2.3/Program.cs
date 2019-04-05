/*
 * Created by SharpDevelop.
 * User: Zali
 * Date: 4/04/2019
 * Time: 4:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Exercise_2._
{
	class Program
	{
		public static void Main(string[] args)
		{
            int counterX = 0;
            int numX = 0;

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