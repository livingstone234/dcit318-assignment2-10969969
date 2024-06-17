using System;

namespace ConsoleApp1
{
    internal class Dog:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
}