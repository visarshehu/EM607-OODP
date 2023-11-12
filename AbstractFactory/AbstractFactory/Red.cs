using System;
namespace AbstractFactory
{
	public class Red : Color
	{
        public override void Fill()
        {
            Console.WriteLine("Filling with red color...");
        }
    }
}

