using System;

namespace Selection_Task {
	
	class Program {
		
		public static void Main(string[] args) {
			
			int age;
			string userInput;
			
			Console.WriteLine("How old are you?");
			
			userInput = Console.ReadLine();
			
			age = int.Parse(userInput);
			
			if (age >= 18) {
				
				Console.WriteLine("Welcome to the bar");
			}
			
			else {
				if (age <= 0) {
					Console.WriteLine("wtf!?");
				}
				else {
					Console.WriteLine("Go watch a Disney movie");
				}
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}