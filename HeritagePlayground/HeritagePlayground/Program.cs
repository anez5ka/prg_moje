using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritagePlayground
{
    internal class Program
    {
        class Animal
        {
            public string name;
            public int maxAge;
            public virtual void MakeNoise()
            {
                Console.WriteLine("*animal sound*");
            }
        }
     
        class Dog:Animal 
        {
            public string breed;
            public override void MakeNoise()
            {
                Console.WriteLine("*woof woof*");
            }
        }

        class Cat : Animal
        {
            public string FurColour;
            public override void MakeNoise()
            {
                Console.WriteLine("*meow meow*");
            }
        }

        static void Main(string[] args)
        {
            Animal newAnimal = new Animal();
            newAnimal.MakeNoise();

            Dog newDog = new Dog();
            newDog.name = "kvido";
            newDog.maxAge = 15;
            newDog.breed = "dumbass";
            Console.WriteLine($"{newDog.name} is {newDog.maxAge} years old and {newDog.breed}");
            newDog.MakeNoise();

            Cat newCat = new Cat();
            newCat.name = "micka";
            newCat.maxAge = 15;
            newCat.FurColour = "white";
            newCat.MakeNoise();

            Console.ReadKey();
        }
    }
}
