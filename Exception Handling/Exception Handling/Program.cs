using System;

namespace Exception_Handling {
    class Program {
        static void Main(string[] args) {
            //Console.Write("Enter a number: ");
            //try {
            //    string input = Console.ReadLine();
            //    if (input.ToLower() == "hitler") {
            //        throw new HitlerException("No Hitlers here");
            //    }

            //    int num = int.Parse(Console.ReadLine());
            //}
            //catch (HitlerException e) {
            //    Console.WriteLine("Error: " + e.Message);
            //}
            //catch (FormatException e) {
            //    Console.WriteLine("Error: " + e.Message);
            //}
            //finally {
            //    Console.WriteLine();
            //    Console.WriteLine("End of Program");
            //}

            //Exercise
            Console.Write("Please input a number: ");
            

            try {
                int num = int.Parse(Console.ReadLine());

                if (num <= 0) {
                    throw new NegativeException("Please input a positive number");
                }

                else if (num > 15) {
                    throw new BigNumberException("Please input a smaller number");
                }

                int m;
                int sum = 0;

                while (num > 0) {
                    m = num % 10;
                    sum += m;
                    num = num / 10;
                }

                Console.WriteLine($"Sum = {sum}");
            }
            catch (FormatException e) {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (NegativeException e) {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (BigNumberException e) {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.WriteLine();
            Console.WriteLine("The time is: " + DateTime.Now.ToString("h:mm:ss tt"));

            Console.ReadKey();
        }
    }

    class NegativeException : Exception {
        public NegativeException(string message) : base(message) {
        }
    }

    class BigNumberException : Exception {
        public BigNumberException(string message) : base(message) {
        }
    }

    //class HitlerException : Exception {
    //    public HitlerException(string message) : base(message) {
    //    }
    //}

    
}
