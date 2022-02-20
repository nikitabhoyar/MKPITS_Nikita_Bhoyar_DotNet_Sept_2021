using System;

namespace C_Dec19_Sum_oF_Individual_Num_Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, a1, a2, a3, a4, sum;
            Console.WriteLine("Enter a Four Digit NUmber ");
            num = Convert.ToInt32(Console.ReadLine());
            a1 = num % 10;
            num = num / 10;

            a2 = num % 10;
            num = num / 10;

            a3 = num % 10;
            num = num / 10;

            a4 = num % 10;
            num = num / 10;

            sum = a1 + a2 + a3 + a4;
            Console.WriteLine("Sum of Individual Digits is " + sum);
        }
    }
}