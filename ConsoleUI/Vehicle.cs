using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    abstract class Vehicle 
    {
        public abstract string Year { get; set; }
        public abstract string Make { get; set; }

        public abstract string Model { get; set; }

        public abstract void DriveAbstract();
        
        public virtual void DriveVirtual(Vehicle vehicle)
        {
            Console.WriteLine($"I am driving my vehicle, it is a {vehicle.Make} {vehicle.Model}. I bought it in {vehicle.Year}");
        }
        
    }
}
