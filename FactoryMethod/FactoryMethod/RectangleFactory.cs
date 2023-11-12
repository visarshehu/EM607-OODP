using System;
namespace FactoryMethod
{
    public class RectangleFactory : ShapeFactory
    {
        public override Shape CreateShape()
        {
            return new Rectangle();
        }
    }
}

