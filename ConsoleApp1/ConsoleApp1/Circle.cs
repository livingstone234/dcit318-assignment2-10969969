using System;

namespace ConsoleApp1
{
    internal class Circle:Shape
    {

        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.Round(Math.Pow(Radius, 2) * Math.PI, 3);
        }
    }
}