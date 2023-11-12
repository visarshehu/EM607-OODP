using System;
namespace AbstractFactory
{
	public abstract class ColorShapeAbstractFactory
	{
		public abstract Shape CreateShape();
		public abstract Color CreateColor();
	}
}

