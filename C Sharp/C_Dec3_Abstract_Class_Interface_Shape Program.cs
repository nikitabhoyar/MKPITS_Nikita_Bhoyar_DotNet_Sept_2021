using System;

namespace C_Dec3_Abstract_Class_Interface_Shape_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //shape s = new Shape();         no object 
            //Circle c = new Circle();      //instance of class
            //c.Area();
            //c.ShowColor();
            //Shape s = new Circle();       //calling function by cirlce
            //s.Area();

            //Shape s1 = new Rectangle();    //calling function by cirlce
            //s1.Area();

            Shape[] shapes = new Shape[4];
            shapes[0] = new Circle();
            shapes[1] = new Rectangle(12,24);
            shapes[2] = new Rectangle(100,25);
            shapes[3] = new Circle(4);
            foreach (Shape s in shapes)
            {
              s.Area();
            }
        }
    }
}
