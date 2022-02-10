using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nikita Bhoyar");
            Console.WriteLine(" is a Software Engineer");
            
            int x = 5, y = 5, length, breadth, r;
            double pi = 3.14;
            char color = 'r';
            decimal price = 45.50m;
            string name = "Nikita Bhoyar";

            Console.WriteLine("x = " + x +  " y =" + y + " color code is " + color);
            Console.WriteLine("pi = " +pi);
            Console.WriteLine("price = " +price);
            Console.WriteLine("My name is " + name);
            Console.WriteLine("x = {0} y = {1} pi = {2:f2} price = {3:C} ", x , y, pi, price);
            Console.WriteLine("Enter your name:  ");
            name = Console.ReadLine();

            Console.WriteLine("Enter value of x ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of y ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x+y=" + (x + y));

            Console.WriteLine("Enter the length");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the breadth");
            breadth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("length*breadth = " + (length * breadth));

            Console.WriteLine("To Find Area of Circle");
            Console.WriteLine("Enter the value of radius");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of Circle = " + (pi * r * r));

            Console.WriteLine("Formated output of Area of Circle is = {0:f2} ", (pi * x * x));

            double Area = Math.PI * x * x;

            Console.WriteLine("String Format Area of Circle is " + Area);

            Console.WriteLine("Display 1 to 10 Number");
            for(int i = 1; i<=10; i++)
            {
                Console.WriteLine(i);
            }
           
            Console.ReadKey();
        }
    }
}
