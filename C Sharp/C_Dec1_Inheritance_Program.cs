
using C_Dec1_Inheraictance_Program;
using System;

namespace C_Dec1_Inheritance_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Mother m1 = new Mother();
            Console.WriteLine(m1);

            Daughter d1 = new Daughter();
            Console.WriteLine(d1);

            Daughter d2 = new Daughter(15, "bina", 45, "tina");
            Console.WriteLine(d2);
        }
    }
}
