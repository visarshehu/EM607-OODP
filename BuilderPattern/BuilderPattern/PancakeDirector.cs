using System;
namespace BuilderPattern
{
	public class PancakeDirector
	{
		public Pancake BuildPancake(PancakeBuilder builder)
		{
			builder.PrepareDough();
            builder.Bake();
            builder.AddTopping();

			return builder.GetPancake();
        }
	}
}

