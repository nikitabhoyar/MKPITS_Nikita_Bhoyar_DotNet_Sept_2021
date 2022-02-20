using System;

namespace C_Dec17_Squares_oF_Numbers_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("Enter the number upto which you want Square of number : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Square series of number");
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(i * i);
            }
        }
    }
}