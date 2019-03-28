using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program {
        static void Main(string[] args) {
            HealPotion[] pots = new HealPotion[4] { new HealPotion(65), new HealPotion(9), new HealPotion(423), new HealPotion(1)};
            Person p1 = new Person("Fred", 1, pots);

            Console.WriteLine("P1 name: " + p1.name);
            Console.WriteLine("P1 health: " + p1.healthPool);
            Console.WriteLine("Number of potions: " + p1.potions.Length);

            p1.usePotion();
            Console.WriteLine("P1 health: " + p1.healthPool + " and " + p1.potions.Length);

            p1.takeDamage(49);

            Console.WriteLine("P1 health: " + p1.healthPool);


            Console.ReadKey();
        }
    }

    public class HealPotion {
        public int health;

        //Constructor
        public HealPotion(int h) {
            health = h;
        }
        public int use() {
            return health;
        }
    }

    public class Person {
        public string name;
        public int healthPool;
        public HealPotion[] potions;

        //constructor
        public Person(string n, int hp, HealPotion[] ps) {
            name = n;
            healthPool = hp;
            potions = ps;
        }

        public HealPotion[] Shorten(HealPotion[] gleeb)
        {
            HealPotion[] newboy = new HealPotion[gleeb.Length - 1];

            int counter = 0;
            while (counter < newboy.Length)
            {
                newboy[counter] = gleeb[counter];
                counter++;
            }
            return newboy;
        }

        public void usePotion() {
            healthPool += potions[potions.Length - 1].health;
            potions = Shorten(potions);
        }

        public void takeDamage(int d) {
            healthPool -= d;
        }
    }
}
