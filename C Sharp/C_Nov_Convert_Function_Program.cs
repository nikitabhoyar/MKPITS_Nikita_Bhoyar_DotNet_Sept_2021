using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Nov_Convert_Function_Program.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string rainbowcolor;
            Console.WriteLine("Enter color code");
            rainbowcolor = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Rainbowcolor color is ",rainbowcolor);

            decimal price;
            Console.WriteLine("Enter the price");
            price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Price = {0:c} ", price);

            bool ans = true;
            Console.WriteLine("Enter answer true|false");
            ans = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("yes I want to repeat " + ans);

            DateTime today;
            Console.WriteLine("Enter date");
            today = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Today is " + today);

        }
    }
}
