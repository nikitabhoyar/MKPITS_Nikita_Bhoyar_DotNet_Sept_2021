using System;

namespace C_Dec19_Even_Odd_Using_IfElse_If
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter any number");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("The number is zero\n");
            }
            else if (n >= 0)
            {
                Console.WriteLine("the number is positve\n");
            }
            else
            {
                Console.WriteLine("the number is negative\n");
            }
            if (n % 2 == 0)
            {
                Console.WriteLine("the number is even\n");
            }
            else
            {
                Console.WriteLine("the number is odd\n");
            }
        }
    }
}