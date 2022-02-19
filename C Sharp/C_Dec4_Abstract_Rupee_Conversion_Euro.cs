using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Dec4_Abstract_rupee_Conversion
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