using System;
using System.Collections;
using System.Collections.Generic;

namespace C_Dec4_Collections
{
    class Program
    {
        static void Main(string[] args)

        {
            decimal price = 230.50m;
            decimal marks = 100;
            //non generic collection class 
            ArrayList myarraylist = new ArrayList();
            //boxing : converting values type to reference type (object) is called boxing (boxing are help to covert of various type) 
            myarraylist.Add(12);
            myarraylist.Add(DateTime.Now);
            myarraylist.Add("Nikita");
            myarraylist.Add("A");
            myarraylist.Add(Math.PI);
            myarraylist.Add(price);
            myarraylist.Add(new Student() { Id = 1, Name = "Akash narwade" });
            myarraylist.Add(marks);
            foreach (object o in myarraylist)
                Console.WriteLine(o);     //unboxing= converting object into its orignal value type 

            //generic class list
            List<Student> students = new List<Student>()
            {
                new Student {Id=1,Name="Nilesh"},
                new Student {Id=1,Name="Priya"},
                new Student {Id=1,Name="Rani"},
                new Student {Id=1,Name="Veeraj"},
                new Student {Id=1,Name="Lisa"},
                new Student { Id = 1, Name = "Shivani" },
            };

            foreach (Student s in students)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Count of student is " + students.Count);

            //non generic class Hashtable 
            Hashtable mytable = new Hashtable();
            mytable.Add(1, "Nikita");
            mytable.Add(4, DateTime.Now.ToShortDateString());
            mytable.Add(7, 67.78m);
            mytable.Add(2, marks);
            mytable.Add(3, null);
            foreach (DictionaryEntry de in mytable)
                Console.WriteLine("Key :{0},Value :{1}", de.Key, de.Value);
            // Generic class 
            // Dictionary<Student> mydictinary = new Dictionary<Student>();

            Stack mystack = new Stack();
            mystack.Push(78);     //for data add =((push)) method
            mystack.Push("Nikita");    //to add push()
            mystack.Push(78.65m);
            mystack.Push(7000.79m);
            mystack.Push("12/08/2021");
            //Last In First out
            Console.WriteLine(mystack.Pop());
            Console.WriteLine(mystack.Pop());
            Console.WriteLine(mystack.Pop());//to remove item from top pop()
            Console.WriteLine(mystack.Peek()); //to see only and not remove the top item 
        }
    }
}

