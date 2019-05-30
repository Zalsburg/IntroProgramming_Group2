using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive {
    class Program {
        static void Main(string[] args){
            Console.WriteLine("We have two beehives! The Beetles hive needs at least 4 bees, and the Nirvana hive needs at least 3 bees.");
            Console.WriteLine("But what should the maximum amount of bees per hive be?");
            Console.WriteLine();
            Console.Write("The Beetles hive: ");
            int beetlesmaxbees = int.Parse(Console.ReadLine());
            Console.Write("The Nirvana hive: ");
            int nirvanamaxbees = int.Parse(Console.ReadLine());

            Beehive Beetles = new Beehive(beetlesmaxbees, new QueenBee("Brian"));
            Beehive Nirvana = new Beehive(nirvanamaxbees, new QueenBee("Danny"));

            Beetles.AddBee(new Bee("John", 3.2f));
            Beetles.AddBee(new Bee("Paul", 2.7f));
            Beetles.AddBee(new Bee("George", 1.1f));
            Beetles.AddBee(new Bee("Ringo", 2.0f));

            Nirvana.Bees.Add(new Bee("Kurt", 2.3f));
            Nirvana.Bees.Add(new Bee("Dave", 7.4f));
            Nirvana.Bees.Add(new Bee("Krist", 1.5f));

            Console.WriteLine();
            Console.WriteLine("Now, how many days of honey collection would you like to view?");
            Console.WriteLine("(whole numbers only)");
            int days = int.Parse(Console.ReadLine());

            float beetleshoney = Beetles.CollectHoney(days);
            float nirvanahoney = Nirvana.CollectHoney(days);

            Console.WriteLine($"There are {Beetles.Bees.Count} bees in the Beetles beehive. They collected {beetleshoney} honey");
            Console.WriteLine($"There are {Nirvana.Bees.Count} bees in the Nirvana beehive. They collected {nirvanahoney} honey");

            Console.WriteLine();
            Console.WriteLine("Would you like to add more bees to the Beetles beehive? (Y/N)");
            string useranswerbeetles = Console.ReadLine().ToUpper();

            while (useranswerbeetles == "Y") {
                Console.WriteLine("What would you like to call the bee?");
                string beename = Console.ReadLine();

                if (Beetles.Bees.Count >= Beetles.MaxBees) {
                    Console.WriteLine("Sorry! This beehive is full!");
                    break;
                }
                else {
                    Beetles.AddBee(Beetles.QueenBee.MakeBee(beename));
                    Console.WriteLine("Would you like to add another bee? (Y/N)");
                    string morebees = Console.ReadLine().ToUpper();
            
                    if (morebees == "N") {
                        break;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Would you like to add more bees to the Nirvana beehive? (Y/N)");
            string useranswernirvana = Console.ReadLine().ToUpper();

            while (useranswernirvana == "Y") {
                Console.WriteLine("What would you like to call the bee?");
                string beename = Console.ReadLine();
                if (Nirvana.Bees.Count >= Nirvana.MaxBees) {
                    Console.WriteLine("Sorry! This beehive is full!");
                    break;
                }

                else {
                    Nirvana.AddBee(Nirvana.QueenBee.MakeBee(beename));
                    Console.WriteLine("Would you like to add another bee? (Y/N)");
                    string morebees = Console.ReadLine().ToUpper();

                    if (morebees == "N") {
                        break;
                    }
                }
                                
            }

            Console.WriteLine();
            Console.WriteLine("The bees in the Beetles hive are...");
            foreach (Bee bee in Beetles.Bees) {
                Console.WriteLine(bee.Name);
            }

            Console.WriteLine();
            Console.WriteLine("The bees in the Nirvana hive are...");
            foreach (Bee bee in Nirvana.Bees) {
                Console.WriteLine(bee.Name);
            }

            Console.ReadKey(true);

        }
    }

    class Beehive {
        public List<Bee> Bees;
        public int MaxBees;
        public QueenBee QueenBee;

        public Beehive(int maxbees, QueenBee queenbee) {
            Bees = new List<Bee>();
            MaxBees = maxbees;
            QueenBee = queenbee;
        }

        public float CollectHoney(int days) {
            float HoneyAmount = 0;
            foreach (Bee bee in Bees) {
                HoneyAmount += days * bee.Size * 0.2f;
            }
            return HoneyAmount;
        }

        public void AddBee(Bee b) {
            if (Bees.Count <= MaxBees){
                Bees.Add(b);
            }
        }
    }

    class Bee {
        public string Name;
        public float Size;

        public Bee(string name, float size) {
            Name = name;
            Size = size;
        }
    }

    class QueenBee : Bee {

        public QueenBee(string name): base(name, 0) {
         
        }

        public Bee MakeBee(string name) {
            return new Bee(name, 0.1f);
        }
        
    }
}
