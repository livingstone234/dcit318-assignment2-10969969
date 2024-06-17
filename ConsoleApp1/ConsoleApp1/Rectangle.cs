using System;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Rectangle: Shape
    {

        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double GetArea()
        {
            return Math.Round(Width * Length, 2);
        }
    }
}