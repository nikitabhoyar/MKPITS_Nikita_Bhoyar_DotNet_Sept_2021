using System;

namespace C_Dec19_Multiplication_Table_Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("enter the number ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < 10; i++)
            {
                Console.Write("{0} X {1} = {2} \n", n, i, n * i);   //concept of table 
            }
        }
    }
}