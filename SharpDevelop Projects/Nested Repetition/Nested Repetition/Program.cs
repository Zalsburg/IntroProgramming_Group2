/*
 * Created by SharpDevelop.
 * User: Zali
 * Date: 21/03/2019
 * Time: 2:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Nested_Repetition {
	class Program {
		public static void Main(string[] args) {
			Console.WriteLine("Please enter your name");
			string name = Console.ReadLine();
			
			int counter =  0;
			
			while (counter < 10) {
				int counter2 = 0;
				
				while (counter2 < 5) {
					Console.Write(name + " ");
					counter2 += 1; //counter2 = counter 2 + 1
					
				} //end while (counter2 < 5)
				
				Console.WriteLine();
				counter += 1;
				
			} //end while (counter < 5)
			
			Console.WriteLine();
			counter += 1;
			
			Console.Write("Press any key to continue");
			Console.ReadKey(true);
		}		
			
		}
	}