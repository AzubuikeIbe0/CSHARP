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

                /*Animal animal = new Animal();*/
                Dog dog = new Dog();
                Elephant elephant = new Elephant();
                Ostrich ostrich = new Ostrich();

            Animal[] animals = {dog, elephant, ostrich};

            foreach(Animal animal in animals)
            {
                Console.WriteLine(animal);
                MakeAnimalSound(animal);
            }

               /* MakeAnimalSound(animal);
                MakeAnimalSound(dog);
                MakeAnimalSound(elephant);
                MakeAnimalSound(ostrich);*/
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
            Console.WriteLine("The Ostrich is  Hissing");
        }
    }




}
