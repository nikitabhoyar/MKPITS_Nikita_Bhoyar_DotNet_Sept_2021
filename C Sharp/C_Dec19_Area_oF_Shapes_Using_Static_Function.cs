using System;

namespace C_Dec19_Static_function_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius;
            int length, breadth;
            int bas, height;
            Console.WriteLine("To find Area of circle");
            Console.WriteLine("Enter the Radius");
            radius = Convert.ToInt32(Console.ReadLine());
            Area_Circle(radius);                                  //main function calling 
            Area_Circle(7);                         //main function using given input R=7
            //Area of Rectangle 
            Console.WriteLine("To Find Area of Rectangle");
            Console.WriteLine("Enter length of Rectangle ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Breadth of Rectangle ");
            breadth = Convert.ToInt32(Console.ReadLine());
            Area_Rectangle(length, breadth);
            //Area of Triangle 
            Console.WriteLine("To Find Area of Triangle");
            Console.WriteLine("Enter Base of triangle ");
            bas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height of Triangle ");
            height = Convert.ToInt32(Console.ReadLine());
            Area_Triangle(bas, height);
        }
        public static void Area_Circle(int r)    //function defination
        {
            //double a;    --it can be also declare like these 
            double a = Math.PI * r * r;
            Console.WriteLine("The Area of Circle is ={0:f3}", a);          //f is upto 3 digit 
        }

        public static void Area_Rectangle(int l, int b)
        {
            int a = l * b;
            Console.WriteLine("Area of Rectangle = " + a);
        }
        public static void Area_Triangle(int b, int h)
        {
            double a1 = 0.5 * b * h;
            Console.WriteLine("Area of Triangle ={0:f3} ", a1);
        }
    }
}
