using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 2019;
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";

        public abstract void DriveAbstract(); //stubbed method, no implementation
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }
    }
}
