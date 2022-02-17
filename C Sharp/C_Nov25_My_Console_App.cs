using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Nov_My_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.Write("Hello! I am Nikita Bhoyar");
            //Console.ReadKey();

            int x = 5, y = 5 , length , breadth , r;
            double pi = 3.14;
            char color = 'r';
            decimal price = 45.50m;
            string name = "Nikita Bhoyar";

            Console.WriteLine("x= " +x+ "y=" +y+ "color code is " +color);
            
            //String Format of writeline
            Console.WriteLine("pi= " +pi  + "price = " +price);
            Console.WriteLine("My name is " +name);

            //Format Output of numeric data//
            Console.WriteLine("x = {0} y={1} pi={2:f2} price = {3:c} , x , y , pi , price ");

            Console.WriteLine("Enter your name ");
            name = Console.ReadLine();
            Console.WriteLine("My name is " + name);

            Console.WriteLine("Enter value of x ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of y ");
            y = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("x + y = " +(x+y (Console.WriteLine("Enter value of x ")));

            Console.WriteLine("Enter the length");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the breadth");
            breadth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("length*breadth = " + (length * breadth));

            //Code3 area of Circle//
            Console.WriteLine("To Find area of Circle");
            Console.WriteLine("Enter the value of radius");

            //r = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Area of Circle = ") + (pi*r*r);

            Console.WriteLine("Formated ouput of Area of Circle is = {0:f2} ", (pi * x * x));

            double Area = Math.PI * x * x;

            Console.WriteLine("String Format Area of Circle is " + Area);

            Console.WriteLine("Display 1 to 10 Numbers");
            for(int i = 1; i<=10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
