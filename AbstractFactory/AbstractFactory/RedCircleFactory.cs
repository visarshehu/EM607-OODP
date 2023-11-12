using System;
namespace AbstractFactory
{
    public class RedCircleFactory : ColorShapeAbstractFactory
    {
        public override Color CreateColor()
        {
            return new Red();
        }

        public override Shape CreateShape()
        {
            return new Circle();
        }
    }
}

