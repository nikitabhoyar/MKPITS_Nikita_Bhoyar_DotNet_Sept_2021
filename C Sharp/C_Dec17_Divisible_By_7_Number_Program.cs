using System;

namespace C_Dec19_Divisible_By_7_Number_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;
            Console.WriteLine("\nEnter any two number");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            sum = a + b;
            {
                Console.WriteLine("\nThe sum of number is={0}", +sum);
            }
            if (sum % 7 == 0)
            {
                Console.WriteLine("\n{0} number is divisible by 7\n", sum);
            }
            else
            {
                Console.WriteLine("\n{0} number is not divisible by 7\n", sum);
            }
        }
    }
}