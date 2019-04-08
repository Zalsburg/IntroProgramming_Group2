/*
 * Created by SharpDevelop.
 * User: Zali
 * Date: 21/03/2019
 * Time: 4:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Arrays_and_Lists
{
	class Program
	{
		public static void Main(string[] args)
		{
            Console.WriteLine("Give me five numbers to add");
			int count = 0;
			int[] scores = new int[5];
			
			//Gather input into the array
			while (count < scores.Length)
			{
				int score = int.Parse(Console.ReadLine());
				scores[count] = score;
				count++;				
			}
			
			//Work out total from the array
			int total = 0;
			count = 0;
			while (count < scores.Length)
			{
				total = total + scores[count];
				count++;
			}
			
			Console.WriteLine("The total is " + total);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}