using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Dec4_Euro_To_Rupees_Conversion_Prog
{
    class Euro : Currency
    {
        public int E { get; set; }
        public Euro()
        {
            E = 60;
        }//abstract method is overridden these class .Area()
        public Euro(int euro)
        {
            E = euro;
        }
        public override void ToRupees()
        {
            Console.WriteLine(" Euro = " + E + "\n Euro To Rupees Conversion = " + E * 84);
        }
    }
}
