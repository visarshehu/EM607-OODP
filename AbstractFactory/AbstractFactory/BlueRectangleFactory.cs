using System;
namespace AbstractFactory
{
    public class BlueRectangleFactory : ColorShapeAbstractFactory
    {
        public override Color CreateColor()
        {
            return new Blue();
        }

        public override Shape CreateShape()
        {
            return new Rectangle();
        }
    }
}

