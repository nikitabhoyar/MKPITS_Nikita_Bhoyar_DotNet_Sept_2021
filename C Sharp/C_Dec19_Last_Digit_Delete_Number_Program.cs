using System;

namespace C_Dec19_Last_Digit_Delete_Number_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number :");
            num = Convert.ToInt32(Console.ReadLine());
            num = num / 10;
            Console.WriteLine("After deleting last Digit Number is = " + num);
        }
    }
}
