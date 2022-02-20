using System;
using System.Collections.Generic;
using System.Text;

namespace C_Dec4_Abstract_Rupee_Conversion_Pound_Prog
{
    class Pound : Currency
    {
        public int p { get; set; }


        public Pound()
        {
            p = 40;
        }//abstract method is overridden these class .ToRupees()
        public Pound(int pound)
        {
            p = pound;
        }


        public override void ToRupees()
        {
            Console.WriteLine(" pound =" + p + "\n Pound To Rupees Conversion = " + p * 5);
        }
    }
}
