using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }
        public bool HasSideCart { get; set; } = true;

        public override void DriveAbstract(Vehicle vehicle)
        {
            Console.WriteLine("This motorcycle is driving");
        }
        public override void DriveVirtual(Vehicle vehicle)
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} and is virtually driving");
        }
    }
}
