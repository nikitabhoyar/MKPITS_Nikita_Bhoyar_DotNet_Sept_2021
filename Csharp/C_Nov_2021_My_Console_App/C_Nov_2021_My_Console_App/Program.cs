using System;

namespace C_Nov_2021_My_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World!\n");                                            //code1
            Console.WriteLine("Nikita Bhoyar is a Software Developer as a Profession"); //Cursor goes
                                                                                        //into next line //


            int x = 20, y = 5;
            double pi = 3.14;       //we not take hear float datatype//
            char color = 'r';
            decimal price = 45.50m;   // m for money //
            string name = "Nikita";
            int radius;
          

            //Console.WriteLine("x  " + x + "y = " + y+ "color code is "+color);

            ////String Format of Writeline//
            //Console.WriteLine("pi = "+pi+ "price=  "+price);
            //Console.WriteLine("My name is " + name);

            ////formated output of numeric data//
            //Console.WriteLine("x={0} y={1} pi={2:F2} price ={3:C}", x, y, pi, price);


            ////Code for Input statement//
            //Console.WriteLine("Enter you Name: ");
            //name = Console.ReadLine();
            //Console.WriteLine("My name is " + name);

            Console.WriteLine("Enter value of x ");
            x = Convert.ToInt32(Console.ReadLine());    //Readline is only for string type//


            Console.WriteLine("Enter value of y ");
            y = Convert.ToInt32(Console.ReadLine());        //Convert.ToInt32 is used for converting 
                                                         //string into int//

            int sum = x + y;
            Console.WriteLine( sum) ;


            Console.WriteLine("Enter the value of radius");
            x = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Formated Output of Area of Circle is ={0:F2}", (pi *x* x));
            double Area = Math.PI * x * x;
            Console.WriteLine("String Format of Area of Circle is = " +Area);









        }
    }
}
