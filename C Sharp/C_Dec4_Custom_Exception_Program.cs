using System;

namespace C_Dec4_Custom_Exception_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            try
            {
                Console.WriteLine("Enter a Number");
                x = Convert.ToInt32(Console.ReadLine());
                //if (x % 2 != 0)    //reminder =1 (odd condition)
                //    throw new MYCustomException("Number is not Even !,Please Enter Even Number ");
                if (x % 5 != 0)    //DIVISIBLE BY 5 (DIVISIBLE 5 condition)
                    throw new MYCustomException("Number is not dIVISIBLE BY 5 !,Please Enter The Number Which is  Dvisible by 5 ");
            }
            catch (MYCustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("byee byee");
            }
            Console.ReadKey();
        }
    }
}
