﻿
using System;

namespace C_Dec1_vehicle_bus_scooter_car
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehical v1 = new Vehical();
            Console.WriteLine(v1);

            Scooter s1 = new Scooter();
            Console.WriteLine(s1);

            Bus b1 = new Bus();
            Console.WriteLine(b1);
        }
    }
}
