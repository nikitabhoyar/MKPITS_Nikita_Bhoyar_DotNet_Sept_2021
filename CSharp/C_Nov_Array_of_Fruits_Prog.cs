using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec_Array_of_Fruits
{
    class Program
    {
      static void Main (String[] args)
        {
            string[] fruits = new string[5];
            Console.WriteLine("Enter Name of Fruits");
            for(int i = 0; i<5; i++)
            {
                fruits[i] = Console.ReadLine();
            }

            Console.WriteLine("Following are the fruis u entered");
            for(int i = 0; i<5; i++)
            {
                Console.WriteLine(fruits[i]);
            }
        }
    }
}
