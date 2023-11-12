using System;
namespace AbstractFactory
{
	public class Blue : Color
	{
        public override void Fill()
        {
            Console.WriteLine("Filling with blue color...");
        }
    }
}

