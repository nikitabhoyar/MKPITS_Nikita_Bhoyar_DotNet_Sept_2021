using System;
using System.Collections.Generic;
using System.Text;

namespace C_Dec3_Abstract_Class_Interface_Circle_Prog
{
    class Circle: Shape
    {
        //Concrete class Circle
        public int Radius { get; set; }
        public Circle()
        {
            Radius = 10;
        }              
        
        //abstract method is overridden these class.Area()
        public Circle(int r)
        {
            Radius = r;
        }
        public override void Area()
        {
            Console.WriteLine("Area of Circle " + (Math.PI * Radius * Radius));
        }
    }
}
