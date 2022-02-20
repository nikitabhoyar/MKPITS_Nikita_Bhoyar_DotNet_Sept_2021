using System;

namespace C_Dec19_StarPyramid_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" * ");    //to recall write 
                }
                Console.WriteLine("\n");
            }
        }
    }
}