using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars {
    class Program {
        static void Main(string[] args) {
            Passenger drive = new Passenger("Dwayne Johnson", 'M', 1960);

            Car c1 = new Car(3500, "Nissan", "370Z", drive);
            c1.Accelerate(5);

            Passenger zali = new Passenger("Zali", 'F', 2003);
            
            Passenger p1 = new Passenger("Anne Clements", 'I', 1970);

            c1.AddPassenger(zali);
            c1.AddPassenger(p1);
            c1.AddPassenger(drive);

            c1.Accelerate(95);

            Console.WriteLine($"Make: {c1.Make} | Model: {c1.Model} | Current Speed: {c1.Speed}");
            Console.WriteLine($"Name: {c1.Driver.Name} | Sex: {c1.Driver.Sex} | Age: {c1.Driver.CalcAge(2019)}");

            Console.ReadKey();
        }
    }

    public class Car { 
        public int EngineCapacity;
        public string Make;
        public string Model;
        public int Speed;
        public Passenger Driver;
        public List<Passenger> Passengers;

        public Car(int ec, string make, string mod, Passenger driver){ 
            EngineCapacity = ec;
            Make = make;
            Model = mod;
            Driver = driver;
            Speed = 0;
            Passengers = new List<Passenger>();
        }

        public void Accelerate(int amount) { 
            Speed += amount;
        }
        
        public void Decelerate(int amount) { 
            if(Speed >= amount) {
                Speed -= amount;  
            }
        }

        public void AddPassenger(Passenger p){ 
            Passengers.Add(p);
        }
    }

    public class Passenger { 
        public string Name;
        public char Sex;
        public int YearOfBirth;

        public Passenger(string name, char sex, int yearOfBirth) {
            Name = name;
            Sex = sex;
            YearOfBirth = yearOfBirth;
        }

        public int CalcAge(int CurrentYear){ 
            return CurrentYear - YearOfBirth;    
        }

        public string GetInfo(){ 
            return $"{Name} \t {Sex}";    
        }
    }
}
