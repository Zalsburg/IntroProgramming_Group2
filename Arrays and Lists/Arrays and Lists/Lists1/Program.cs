using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me five numbers");

            List<int> numbers = new List<int>();

            int count = 0;

            while (count < 5) {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
                count++;
            }

            Console.WriteLine("Now give me one more number");

            int xtranumber = int.Parse(Console.ReadLine());

            if (numbers.Contains(xtranumber))
            {
                Console.WriteLine("Sorry, that number has already been added");
            }

            else {
                Console.WriteLine("That number is not in the list!");
            }

            Console.ReadKey(true);
        }
    }
}
