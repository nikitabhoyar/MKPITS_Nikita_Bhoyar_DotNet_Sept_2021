using System;
using System.Collections.Generic;
using System.Text;

namespace C_Dec3_Abstract_Class_Interface_Shape_Copy_Prog

{ 
    abstract class Shape      //abstract is use 
    {
        public string color { get;set;}
        public abstract void Area();     //method or function
        public virtual void ShowColor()  //virtula -reusibility
        {
            Console.WriteLine("Color of Shape");
        }

    }
}
