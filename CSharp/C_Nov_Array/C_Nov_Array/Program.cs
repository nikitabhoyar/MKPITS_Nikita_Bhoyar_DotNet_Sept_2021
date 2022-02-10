using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Nov_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = new string[5];
            Console.WriteLine("Enter name of Fruits");
            for(int i=0; i<5; i++)
            {
                fruits[i] = Console.ReadLine();
            }

            Console.WriteLine("Following are the fruits u entered");
            for(int i=0; i<5; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            int[] marks = new int[5];
            Console.WriteLine("Enter Five Number");
            int sum = 0;
            for(int i=0; i<5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Console.WriteLine("Given marks are ");
            //for(int i=0;i<5;i++)
            {
                Console.WriteLine("Given marks are ");
                for(int i=0; i<5; i++)
                {
                    Console.WriteLine(marks[i]);
                    sum += marks[i];
                }

                //Console.WriteLine("Sum of marks=" + sum);
                //Console.ReadKey();

                string[] Fruits = { "Apple", "Orange", "Banana ", "Grapes", "Mango" };
                Console.WriteLine("Fruit names");

                foreach(string f in fruits)
                {
                    Console.Write(f + " ");
                }

                Console.WriteLine("Size of array is " + fruits.Length);
                Array.Sort(Fruits);

                Console.WriteLine("sorted array of fruits is");
                foreach (String f in fruits)
                {
                    Console.Write(f + " ");
                }

                Array.Reverse(fruits);
                Console.WriteLine("Sorted array of fruits in descending order ");

                {
                    Console.Write(" ");
                }
            }
        }
    }
}
