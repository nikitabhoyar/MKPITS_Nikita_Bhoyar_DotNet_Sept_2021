using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    delegate int mydelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            mydelegate obj = new mydelegate(Sum);
            int ans = obj(40, 5);
            Console.WriteLine("Addition of two numbers=" + ans);
            obj += new mydelegate(Subtract);
            int ans2 = obj(20, 30);
            Console.WriteLine(" Subtraction of two numbers=" + ans2);
        }
        public static int Sum (int a , int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

       // public static int Multiply(int a, int b)
        //{
           // return a * b;//
        //}//


    }
}
