using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {

        }
        public bool HasTrunk { get; set; } = true;
        public override void DriveAbstract(Vehicle vehicle)
        {
            Console.WriteLine("This car is driving");
        }

        
    }
}
