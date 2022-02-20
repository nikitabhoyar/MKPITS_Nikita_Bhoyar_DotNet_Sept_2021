using System;

namespace C_Dec17_Ternary_Operator_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4, j = 2, k;
            Console.WriteLine("Ternary Operation");
            Console.WriteLine("Value of i = " + i);
            Console.WriteLine("Value of i = " + j);
            k = (i--) * (i--) + (2 * j);
            Console.WriteLine("the value are k = " + k);
        }
        // Console.WriteLine("the value are k" + k);
    }
}