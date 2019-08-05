using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Practice_Challenge {
    class Program {
        static void Main(string[] args) {
        }
    }

    class Transport {
        public string Make;
        public string Model;
        public Color Colour;

        public Transport(string make, string model, Color colour) {
            Make = make;
            Model = model;
            Colour = colour;
        }
    }

    class Aeroplane : Transport {
        public int WingSpan;
        public int PassengerLimit;
        public int Passengers;

        public Aeroplane(string make, string model, Color colour, int span, int passlimit, int passengers) : base(make, model, colour) {
            WingSpan = span;
            PassengerLimit = passlimit;
            Passengers = passengers;
        }

        public string Fly() {
            Console.WriteLine("Whooosh!");
            return "Whooosh!";
        }

        public bool AddPassengers(int pass) {
            if (pass + Passengers <= PassengerLimit) {
                Passengers += pass;
                return true;
            }
            else {
                return false;
            }
        }
    }

    class Car : Transport {
        public int Wheels;
        public string Rego;

        public Car(string make, string model, Color colour, int wheels, string rego) : base(make, model, colour) {
            Wheels = wheels;
            Rego = rego;
        }

        public string Drive() {
            Console.WriteLine("Broooom Broooom!");
            return "Broooom Broooom!";
        }
    }

    class Ute : Car {
        public int CarryLimit;
        public int Load;

        public Ute(string make, string model, Color colour, int wheels, string rego, int carlimit, int load) : base(make, model, colour, wheels, rego) {
            CarryLimit = carlimit;
            Load = load;
        }

        public bool AddLoad(int addload) {
            if (addload + Load <= CarryLimit) {
                return true;
            }
            else {
                return false;
            }
        }
    }

    class Sedan : Car {
        public int Doors;
        public int PassengerLimit;
        public int Passengers;

        public Sedan(string make, string model, Color colour, int wheels, string rego, int doors, int passlimit, int passengers) : base(make, model, colour, wheels, rego) {
            Doors = doors;
            PassengerLimit = passlimit;
            Passengers = passengers;
        }

        public bool AddPassenger() {

        }
    }
}
