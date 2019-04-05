/*
 * Created by SharpDevelop.
 * User: Zali
 * Date: 4/04/2019
 * Time: 4:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Exercsise_2._
{
	class Program
	{
		public static void Main(string[] args)
		{
			int counterX = 0;

            Console.WriteLine("How many Xs would you like on the first line?");
            string userX = Console.ReadLine();
            int numX = int.Parse(userX);
            
            int numY = 0;
            
            while (counterX < numX) {
                int counterY = numX;
                
                while (counterY > numY) {
                    Console.Write("x");
                    counterY--;
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