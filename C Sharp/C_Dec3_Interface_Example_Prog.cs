using System;

namespace C_Dec3_Interface_Example_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.GetSpeed(120);//define in class car
            c.ShowSpeed();  //define in vehicl
            c.Print();      //from interface and IPrintable
            c.Display();

        }
    }
}
