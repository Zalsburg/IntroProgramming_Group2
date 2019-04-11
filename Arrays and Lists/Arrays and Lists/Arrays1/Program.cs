using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string[] names = new string[5];

            Console.WriteLine("Please give me five names");

            while (count < names.Length) {
                string name = Console.ReadLine();
                names[count] = name;
                count++;
            }

            int count2 = 0;
            while (count2 < names.Length) {
                Console.WriteLine("Hello " + names[count2]);
                count2++;
            }

            Console.ReadKey(true);
        }
    }
}
