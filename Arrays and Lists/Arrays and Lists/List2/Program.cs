using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me five numbers");

            List<int> numbers = new List<int>();

            int count = 0;

            while (count < 5)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
                count++;
            }

            Console.WriteLine("Please give me another number");

            int number2 = int.Parse(Console.ReadLine());

            //Using foreach
            int amount = 0;
            foreach (int element in numbers) {
                if (number2 == element) {
                    amount++;
                }
            }

            
            Console.WriteLine("That number has been entered " + amount + " times!");

            //Using LINQ (Reccommended by Lochie)
            int total = numbers.Count(element => element == number2);
            Console.WriteLine("According to the LINQ method, that number has been entered " + total + " times!");

            Console.ReadKey(true);
        }
    }
}
