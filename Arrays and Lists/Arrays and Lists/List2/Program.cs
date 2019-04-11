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

            int amount = 0;
            foreach (int element in numbers) {
                if (number2 == element) {
                    amount++;
                }
            }


            Console.WriteLine("That number has been entered " + amount + " times!");

            Console.ReadKey(true);
        }
    }
}
