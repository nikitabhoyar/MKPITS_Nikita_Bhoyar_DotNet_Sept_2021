
using System;

namespace C_Dec1_Inheritance_Father_Son_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Father f1 = new Father();
            Console.WriteLine(f1);

            Son s1 = new Son();
            Console.WriteLine(s1);

            //Son s2 = new Son(15, "Ayush", 18, "Manish");
            //Console.WriteLine(s2);
        }
    }
}