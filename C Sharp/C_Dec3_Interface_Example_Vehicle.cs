using System;
using System.Collections.Generic;
using System.Text;

namespace C_Dec3_Interface_Example
{
    abstract class Vehicle
    {
        public int Speed { get; set; }
        public abstract void ShowSpeed();
    }
}