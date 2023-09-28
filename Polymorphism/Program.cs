using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Polymorphism
{


    class Travel
    {
        static void Main(string[] args)
        {
            // Many forms, Object identified by more than
            // One type eg. A dog is also: Canine, Animal, Organism

            Car car = new Car();
            Bus bus = new Bus();
            Lorry lorry = new Lorry();
            Bicylce bicylce = new Bicylce();
            Boat boat = new Boat();

            // An array
            Vehicle[] vehicles = { car, bus, lorry, bicylce, boat };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }
            Console.ReadKey();
        }


    }

    class Vehicle
    {
        public virtual void Go() { }
    }

    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The Car is moving!");
        }
    }

    class Bus : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The Bus is moving!");
        }
    }

    class Lorry : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The Lorry is moving!");
        }
    }

    class Bicylce : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The Bicycle is moving!");
        }
    }

    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The Boat is moving!");
        }
    }


}
