using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec1_Inheritance_Daughter
{   
    class Daughter : Mother   ///first write here 
    {
        public int D_age { get; set; }
        public string D_Name { get; set; }

        public Daughter() : base() //default constructor
        {
            D_age = 12;
            D_Name = "trisha";
            // Console.WriteLine("Daughter object Created");
        }
        public Daughter(int dage, string dname, int mage, string mname) : base(mage, mname)
        {
            D_age = dage;
            D_Name = dname;
            Console.WriteLine("Daughter object Created");
        }

        public override string ToString()
        {
            return base.ToString() + " Daughter's Name " + D_Name + "  " + D_age;
        }
    }

}

