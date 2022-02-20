using System;

namespace C_Dec17_Even_Numbers_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            Console.WriteLine("Enter the number ");
            for (int i = 2; i <= 100; i++)
            {
                if (i % 2 == 0)                 //even logic
                    j++;
                Console.WriteLine(i);
            }
            Console.WriteLine("The even no are " + j);  //for count 
        }
    }
}
