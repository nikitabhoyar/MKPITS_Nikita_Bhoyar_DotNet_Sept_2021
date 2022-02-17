using C_Dec3_Inheritance_Circle_Program;
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Dec3_Inheritance_Circle_Program
{

    /// THIS IS THE EXAMPLE OF MULTILEVEL INHERICTANCE 

    class Circle : Point
    {
        protected int Radius { get; set; }

        public Circle()
        {
            Radius = 10;
        }
        public virtual double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public Circle(int radius, int x, int y) : base(x, y)
        {
            Radius = radius;
        }
    }
}