using System;
namespace FactoryMethod
{
	public class CircleFactory : ShapeFactory
	{
        public override Shape CreateShape()
        {
            return new Circle();
        }
    }
}

