using System;

namespace HelloWorld {
	class Program {
		
		public static void Main(string[] args) {
			//declarations
			int num1;
			int num2;
			string inputStorage1;
			string inputStorage2;
			
			//Ask for two numbers
			Console.WriteLine("Give me two numbers");
			
			//Read the input numbers from user
			inputStorage1 = Console.ReadLine();
			inputStorage2 = Console.ReadLine();
			
			num1 = int.Parse(inputStorage1);
			num2 = int.Parse(inputStorage2);
			
			//Calculate answer
			int answer = num1 + num2;
			
			//Output answer
			Console.WriteLine(answer);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}