using System;
namespace AbstractFactory
{
	public class Rectangle : Shape
	{
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle...");
        }
    }
}

