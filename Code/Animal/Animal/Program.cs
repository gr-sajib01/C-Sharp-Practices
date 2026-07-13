using System;

namespace Animal
{
    class Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("Animal makes sound");
        }
    }

    class Dog : Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Cat : Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            Dog dog1 = new Dog();
            Cat cat1 = new Cat();

            animal1.MakeSound();
            dog1.MakeSound();
            cat1.MakeSound();
        }
    }
}