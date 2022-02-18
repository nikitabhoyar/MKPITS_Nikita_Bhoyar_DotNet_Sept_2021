using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Nov_25_Array_Prog
{
    class Program
    {
        static void Main(string[] args)
        {   
            //!--------------------Code1------------------------!//
            //datatype[] name of the array = new datatype[size]
            //string[] Fruits = new string[5];
            //Console.WriteLine("Enter your fruits name");

            //for (int i=0; i<=5; i++)
            //{
            // Fruits[i] = Console.ReadLine();          //Input ForLoop
            //}

            //Console.WriteLine("Following are the fruits you entered");
            //for(int i=0; i<=5; i++)
            //{
            //    Console.WriteLine(Fruits[i]);
            //}
            

            //!------------------------Code2--------------------!//
            //int[] marks = new int[5];
            //Console.WriteLine("Enter Five Numbers");

            //int Sum = 0;
            //for (int i = 0; i <= 5; i++)
            //{
            //    marks[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("Given marks are ");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(marks[i]);
            //    Sum += marks[i];
            //}

            //Console.WriteLine("Sum of marks= " + Sum);
            Console.ReadKey();

            string[] fruits = { "Apple", "Orange", "Banana", "Grapes", " Mango" };
            Console.Write("Fruits names");

            foreach (string f in fruits)
            {
                Console.Write(f + " ");
            }

            Console.WriteLine("Size of array is " + fruits.Length);
            Array.Sort(fruits);

            Console.WriteLine("Sorted array of fruits is ");

            foreach (string f in fruits)
            {
                Console.Write(f + " ");
            }

            Array.Reverse(fruits);

            Console.WriteLine("Sorted array of fruits in descending order");
            foreach (string f in fruits)
            {
                Console.Write(f + " ");
            }

        }
    }
}
