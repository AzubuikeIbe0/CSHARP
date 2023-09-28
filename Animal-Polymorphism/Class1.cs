using System;

namespace Animal_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            void MakeAnimalSound(Animal animal)
            {
                animal.MakeSound();
            }

            Dog dog = new Dog();
            Elephant elephant = new Elephant();
            Ostrich ostrich = new Ostrich();

            // Create an array of Animal objects
            Animal[] animals = { dog, elephant, ostrich };

            foreach (Animal animal in animals)
            {
                // Print a message indicating the type of animal
                Console.WriteLine($"Animal Type: {animal.GetType().Name}");

                // Call the MakeSound method for each animal
                MakeAnimalSound(animal);

                // Add a line break for better readability
                Console.WriteLine();
            }
        }
    }

    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Generic Animal Sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The dog is barking");
        }
    }

    class Elephant : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The elephant is Trumpetting");
        }
    }

    class Ostrich : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The Ostrich is Hissing");
        }
    }
}
