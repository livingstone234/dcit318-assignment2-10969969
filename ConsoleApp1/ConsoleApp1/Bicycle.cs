using System;

namespace ConsoleApp1
{
    internal class Bicycle:IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }
}