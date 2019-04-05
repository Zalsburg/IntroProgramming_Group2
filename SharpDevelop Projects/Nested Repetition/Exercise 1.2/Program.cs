/*
 * Created by SharpDevelop.
 * User: Zali
 * Date: 21/03/2019
 * Time: 3:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Exercise_1._ {
	class Program {
		public static void Main(string[] args) {
			Console.WriteLine("Please enter your name");
			string name = Console.ReadLine();
			
			Console.WriteLine("How many times would you like me to say it? (Squared)");
			string nametimes = Console.ReadLine();
			
			int amount;
			amount = int.Parse(nametimes);
			
			int counter =  0;
			
			while (counter < amount) {
				int counter2 = 0;
				
				while (counter2 < amount) {
					Console.Write(name + " ");
					counter2 += 1; //counter2 = counter 2 + 1
					
				} //end while (counter2 < 5)
				
				Console.WriteLine();
				counter += 1;
				
			} //end while (counter < 5)
			
			Console.WriteLine();
			counter += 1;
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}