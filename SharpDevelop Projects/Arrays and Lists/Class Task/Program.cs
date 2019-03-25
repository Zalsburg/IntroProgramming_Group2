/*
 * Created by SharpDevelop.
 * User: Zali
 * Date: 21/03/2019
 * Time: 5:25 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Class_Task
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please give me ten numbers");
			int count = 0;
			int[] numbers = new int[10];
			
			while (count < numbers.Length)
			{
				int score = int.Parse(Console.ReadLine());
				numbers[count] = score;
				count++;
			}
			
			while (count > 0)
			{
				count--;
				Console.WriteLine(numbers[count]);
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}