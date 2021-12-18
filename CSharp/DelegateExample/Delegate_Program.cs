
//Multicast delegate//can execute more than one methods ata time and its return type always be void// 
//Datatype ansd sequence should be matched//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    delegate void mydelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            mydelegate obj = new mydelegate(Sum);
            obj += new mydelegate(Subtract);
            obj += new mydelegate(Multiply);
            obj += new mydelegate(Division);
            obj(500, 5);
        }
        public static void Sum (int a , int b)
        {
            Console.WriteLine("Addition =" + (a + b));
            
        }

        public static void Subtract(int a, int b)
        {
            Console.WriteLine("Subtraction =" + (a - b));
        }
         public static void Multiply(int a, int b)
        {
            Console.WriteLine("Multiply =" + (a * b));
        }

        public static void Division(int a, int b)
        {
            Console.WriteLine("Division =" + (a / b));
        }


    }
}
