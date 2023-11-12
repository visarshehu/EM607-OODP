using System;
namespace BuilderPattern
{
	public abstract class PancakeBuilder
	{
		public abstract void PrepareDough();
		public abstract void Bake();
		public abstract void AddTopping();

		public abstract Pancake GetPancake();
	}
}

