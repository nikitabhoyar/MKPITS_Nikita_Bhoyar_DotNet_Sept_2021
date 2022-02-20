using System;

namespace C_Dec17_Nested_Decrement_Pattern_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 5; i >= 1; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(i);      //to display as it is the value of i
                }
                Console.WriteLine("\n");
            }
        }
    }
}