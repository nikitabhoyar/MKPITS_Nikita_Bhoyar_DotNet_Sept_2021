using System;

namespace C_Dec4_Properties_Exception_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = { 45, 67, 78, 78 };
            try
            {
                f1();
                for (int i = 0; i < 7; i++)
                Console.WriteLine(marks[i]);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);     //message
                Console.WriteLine(ex.Source);      //source
                Console.WriteLine(ex.StackTrace); //stacktrace
                Console.WriteLine(ex.TargetSite);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Tata Bye Bye I am Ending Your Programs");
            }
        }
        public static void f1()
        {
            f2();
        }
        public static void f2()
        {
            f3();
        }
        public static void f3()
        {
            int x = 10, y = 0;
            Console.WriteLine("X/Y = " + x / y);
        }
    }

}
