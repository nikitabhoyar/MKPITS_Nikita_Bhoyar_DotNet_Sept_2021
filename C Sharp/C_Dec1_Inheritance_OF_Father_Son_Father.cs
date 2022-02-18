
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Dec1_Inheritance_OF_Father_Son_Father
{
    class Father
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Father()
        {
            Age = 45;
            Name = "Devanand";
            // Console.WriteLine("Father Object Created");
        }
        public Father(int age, string name)
        {
            Age = age;
            Name = name;
            Console.WriteLine("Father Object Created");
        }
        public override string ToString()
        {
            return " Father's Name " + Name + " Age " + Age;
        }
    }
}
