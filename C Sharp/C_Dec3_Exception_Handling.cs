using System;

namespace C_Dec3_Exception_handling
{
    class Program
    {
        // 1 SYNTAX ERROR -Programming
        // 2 Logical error -testing 
        // run time error - can not be removed (avoided)
        //Exception
        static void Main(string[] args)
        {
            try
            {
                int x = 10, y = 0;
                Console.WriteLine(x / y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}