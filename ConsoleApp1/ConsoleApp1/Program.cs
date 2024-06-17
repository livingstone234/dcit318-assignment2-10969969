using System;
using System.Data.Common;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal ani = new Animal();
            ani.MakeSound();

            Dog dog = new Dog();
            dog.MakeSound();

            Cat cat = new Cat();
            cat.MakeSound();
        }
    }
}
