using System;

namespace C_Dec17_Array_Basic_Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];
            Console.WriteLine("Enter the Marks of Stuent ");
            for (int i = 0; i < 5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());     //we can convert here upar bhi int declare and convert me bhi

            }
            Console.WriteLine("The NUmbers Are as Follows");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(marks[i]);
            }
        }
    }
}