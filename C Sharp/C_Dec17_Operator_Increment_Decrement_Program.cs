using System;

namespace C_Dec17_Operator_Increment_Decrement_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 8;
            Console.WriteLine("the value before + operator =" + i);
            i++;
            Console.WriteLine("the value After + operator =" + i);

            Console.WriteLine("\n");

            Console.WriteLine("the value before - operator =" + j);
            j--;
            Console.WriteLine("the value After - operator =" + j);
        }
    }
}
