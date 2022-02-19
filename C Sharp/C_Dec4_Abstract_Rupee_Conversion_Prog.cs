using System;
using System.Collections.Generic;
using System.Text;

namespace C_Dec4_Abstract_Rupee_Conversion_Prog
{
    abstract class Currency      //abstract is use 
    {
        public string Conversion { get; set; }
        public abstract void ToRupees();  //method or function
    }
}
