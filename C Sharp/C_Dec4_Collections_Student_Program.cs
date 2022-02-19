using System;
using System.Collections.Generic;
using System.Text;

namespace C_Dec4_Collections_Student_Program
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return " Id " + Id + " Name " + Name;
        }
    }
}