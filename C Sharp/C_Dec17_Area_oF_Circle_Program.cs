using System;

namespace C_Dec17_Area_oF_Circle_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int Radius;
            for (i = 1; i < 5; i++)
            {
                Console.WriteLine("Enter the radius of Circle : ");
                Radius = Convert.ToInt32(Console.ReadLine());
                // pie * Radius * Radius;
                // Console.WriteLine("Area of Circle" + (Math.PI * Radius * Radius));
            }
        }

    }
}