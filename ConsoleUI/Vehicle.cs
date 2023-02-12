using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
		public string Year { get; set; } = "";
		public string Make { get; set; } = "";
		public string Model { get; set; } = "";


		public abstract void DriveAbstract(); // stubbed out method bc of abstract keyword
		public virtual void DriveVirtual()
		{
			Console.WriteLine($"This {GetType().Name} is virtually driving"); ;
		}

	}
}

