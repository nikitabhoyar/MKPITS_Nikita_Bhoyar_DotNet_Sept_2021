using System;

namespace C_Dec19_Swap_Numbers_Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int a, b;
                Console.WriteLine("Enter two number");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number before swaping is {0} {1}", a, b);
                a = a + b;
                b = a - b;
                a = a - b;
                Console.WriteLine("After swaping no is {0} {1}", a, b);
            }
        }
    }
}