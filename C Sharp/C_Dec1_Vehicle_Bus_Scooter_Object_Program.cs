
using System;

namespace C_Dec1_Vehicle_Bus_Scooter_Object_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehical();
            Console.WriteLine(v1);

            Scooter s1 = new Scooter();
            Console.WriteLine(s1);

            Bus b1 = new Bus();
            Console.WriteLine(b1);
        }
    }
}
