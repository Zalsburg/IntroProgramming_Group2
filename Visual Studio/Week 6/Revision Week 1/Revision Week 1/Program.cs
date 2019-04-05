using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_Week_1 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter PIN");
            string pinInput = Console.ReadLine();
            int pinNumber;

            pinNumber = int.Parse(pinInput);

            int counter = 0;
            while (counter < pinNumber) {
                counter++;
            }

            Console.WriteLine("Calculating...");
            Console.WriteLine("Is your PIN " + counter + "?");

            Console.ReadKey(true);
            
        }
    }
}
