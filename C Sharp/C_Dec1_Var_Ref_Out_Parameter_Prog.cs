using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec1_Var_Ref_Out_Parameter_Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 10;          //interference  as x is int  
            var price = 80.50m;  //money is used for decimal type
            var r = 5.689;
            var name = "akash";
            Console.WriteLine(" x=" + x + " price =" + price + " r =" + r + " name =" + name);

            int a = 200, b = 100;
            Console.WriteLine("A =" + a + "B =" + b + " \nbefore calling swap function");
            Swap(ref a, ref b);           //ref is used as a pointer(*) 
            Console.WriteLine("A =" + a + "B =" + b + "\nafter calling swap function");

            //code 2 call by value  (it only show the input)
            Swap(a, b);
            Console.WriteLine("A =" + a + "B =" + b + "\nafter calling swap function");

            //code3
            int radius = 7;
            double ar;
            Area(ref radius, out ar);
            Console.WriteLine("area of circle and their radius are :::"); //to display only the sentence 
            Console.WriteLine(" radius =" + r + "\n Area of circle =" + ar);

            //code 4
            int length = 10;
            int breadth = 20;
            double area;
            Area(ref length, ref breadth, out area);   //jo yaha hai vhe = k baad honga 
            Console.WriteLine("length =" + length + "breadth =" + breadth + "\n Area of rectangle =" + area);
            viewnames('b', 3, "Akash", "sonu", "Sky");
        }

        public static void Swap(ref int x, ref int y)     //ref is used as a pointer(*) 
        {
            int temp = x;
            x = y;
            y = temp;
        }
        ///code 2 with the help of call by value 
        public static void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        //code 3
        public static void Area(ref int r, out double a)  //(out double) is store and display the result 
        {
            a = Math.PI * r * r;
        }
        public static void Area(ref int l, ref int b, out double a)
        {
            a = l * b;
        }

        //parameter 
        static void viewnames(char x, int n, params string[] names)
        {
            if (x == 'b')
            {
                Console.WriteLine("boys present in my class are :");
                for (int i = 0; i < n; i++)
                    Console.WriteLine(names[i]);
            }
            else if (x == 'g')
            {
                Console.WriteLine("gilrs present in my class are :");
                for (int i = 0; i < n; i++)
                    Console.WriteLine(names[i]);
            }
        }

    }
}
