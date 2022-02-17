using System;
using System.Collections.Generic;
using System.Text;

namespace C_Dec3_IComparable_Student
{
    class Student : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public Student()
        {
            Id = 1;
            Name = "Nikita";
            Year = 1990;
        }
        public Student(int id, string name, int year)
        {
            Id = id;
            Name = name;
            Year = year;
       }
       public int CompareTo(object obj)     //object convert into students 
        {
            Student s = (Student)obj;//typecasting
            ///****code 1***///  compare of id
            //if (this.Id < s.Id)
            //    return -1;
            //else
            //    if (this.Id > s.Id)
            //    return 1;
            //else
            //    return 0;


            ////**code2***///   compare of year
            if (this.Year < s.Year)
                return -1;
            else
               if (this.Year > s.Year)
                return 1;
            else
                return 0;
        }
        public override string ToString()
        {
            return Id + "  " + Name + " " + Year;
        }
    }
}
