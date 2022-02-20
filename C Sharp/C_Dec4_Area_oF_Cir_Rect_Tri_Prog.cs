using System;

namespace C_Dec19_Area_oF_Cir_Rect_Tri_Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            //Function overloading : given extra task to the same function
            //operator overloading : given extra task to an operator 
            
            Console.WriteLine("Enter the value number");
            Console.WriteLine("Enter value of length");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  value of Breadth");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  value of Height");
            double h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  value of Radius");
            int r = Convert.ToInt32(Console.ReadLine());
            Area(r);
            Area(l, b);
            Area(b, h);
        }
        public static void Area(int r)    //function defination
        {
            //double a;    --it can be also declare like these 
            double a = Math.PI * r * r;
            Console.WriteLine("The Area of Circle is ={0:f3}", a);          //f is upto 3 digit 
        }
        public static void Area(int l, int b)
        {
            int a = l * b;
            Console.WriteLine("Area of Rectangle = " + a);
        }
        public static void Area(int l, double h)
        {
            double a1 = 0.5 * l * h;

            Console.WriteLine("Area of Triangle ={0:f3} ", a1);
        }
    }
}
