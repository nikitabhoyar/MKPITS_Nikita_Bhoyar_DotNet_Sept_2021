using C_Dec3_Interface_Example;
using System;

namespace C_Dec3_Interface_Example_Car_Prog
{
    internal class Car : Vehicle, IPrintable, IDisplayble
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Seats { get; set; }
        public int Speed { get; private set; }

        public Car()
        {
            Brand = "Maruti";
            Model = "Dezier";
            Color = "silver Metal";
            Seats = 6;
        }
        public void GetSpeed(int s)
        {
            Speed = s;
        }
        public override void ShowSpeed()
        {
            Console.WriteLine("Speed of this car " + Speed);
        }

        public void Print()
        {
            Console.WriteLine(" Model " + Model + " Brand " + Brand);
        }

        public void Display()
        {
            Console.WriteLine(" Color " + Color + " Seats " + Seats);
        }
    }
}
