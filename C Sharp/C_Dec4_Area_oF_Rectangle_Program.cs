using System;

namespace C_Dec17_Area_of_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = 4;
            double width = 2;
            double area;
            Console.WriteLine("lenght of Rdctangle = " + length);
            Console.WriteLine("Width of Rdctangle = " + width);

            area = length * width;
            Console.WriteLine("Area of Rectangle = " + area);
        }
    }
}