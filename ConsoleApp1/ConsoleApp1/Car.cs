using System;

namespace ConsoleApp1
{
    internal class Car:IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }
}