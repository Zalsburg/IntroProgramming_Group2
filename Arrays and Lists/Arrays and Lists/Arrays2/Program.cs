using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 34, 5, 67, 1, 99, 34, 44, 78, 34, 0 };

            Console.WriteLine("Calculating " + numbers[0] + " + " + numbers[1] + " + " + numbers[2] + " + " + numbers[3] + " + " + numbers[4] + " + " + numbers[5] + " + " + numbers[6] + " + " + numbers[7] + " + " + numbers[8] + " + " + numbers[9] + "...");

            int count = 0;
            int sum = 0;

            while (count < numbers.Length) {
                sum += numbers[count];
                count++;
            }

            Console.WriteLine("The answer is... " + sum);

            Console.ReadKey(true);
        }
    }
}
