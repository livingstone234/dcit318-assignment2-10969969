using System;

namespace ConsoleApp1
{

    internal class Program
    {
        static void Main(string[] args)
        {

            /* Animal ani = new Animal();
             ani.MakeSound();

             Dog dog = new Dog();
             dog.MakeSound();

             Cat cat = new Cat();
             cat.MakeSound();*/

            /*Circle circle = new Circle(4);
            Console.WriteLine("The area for a circle of radius {0} is {1}.", circle.Radius, circle.GetArea());

            Rectangle rectangle = new Rectangle(4, 3);
            Console.WriteLine("The area for a rectangle of dimension {0} x {1} is {2}.", rectangle.Length, rectangle.Width, rectangle.GetArea());*/

            Car car = new Car();
            car.Move();

            Bicycle bike = new Bicycle();
            bike.Move();

        }
    }
}
