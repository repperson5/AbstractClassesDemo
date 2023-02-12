using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()//default constructor since this is a nonabstract class
        {

        }

        public bool HasTrunk { get; set; } = true;
        public override void DriveAbstract()
        {
            Console.WriteLine($"This {GetType().Name} is in drive abstractly.");
        }
    }
}

