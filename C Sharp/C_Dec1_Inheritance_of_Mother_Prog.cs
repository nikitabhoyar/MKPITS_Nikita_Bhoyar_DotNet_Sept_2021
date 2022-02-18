using System;

namespace C_Dec1_Inheritance_of_Mother_Prog
{
    class Mother
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Mother()
        {
            Age = 45;
            Name = "Varsha";
            Console.WriteLine("Mother Object Created");

        }
        public Mother(int age, string name)
        {
            Age = age;
            Name = name;
            Console.WriteLine("Mother Object Created");
        }
        public override string ToString()
        {
            return " Mother's Name " + Name + " Age " + Age;
        }
    }
}
