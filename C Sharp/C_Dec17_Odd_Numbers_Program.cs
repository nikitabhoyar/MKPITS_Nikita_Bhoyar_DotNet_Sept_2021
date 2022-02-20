using System;
namespace C_Dec17_Odd_Numbers_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            Console.WriteLine("Enter the Numbers");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)           ///odd condition
                {
                    j++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Odd number are" + j);    //count of odd number 
        }
    }
}