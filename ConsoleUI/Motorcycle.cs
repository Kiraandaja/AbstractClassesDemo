using System;
namespace ConsoleUI
{
    public class Motorcycle: Vehicle
    {
        public Motorcycle()
        {
        }
        public bool HasSideCart { get; set; } = false;
        public override void DriveAbstract()
        {
            Console.WriteLine("This Motorcycle is in drive!");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive.");  
        }
    }
}
