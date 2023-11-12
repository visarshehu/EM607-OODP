using System;
namespace BuilderPattern
{
	public class BlueberryPancakeBuilder : PancakeBuilder
	{
        Pancake pancake = new BlueberryPancake();

        public override void AddTopping()
        {
            pancake.AddStep("Add blueberry surup!");
        }

        public override void Bake()
        {
            pancake.AddStep("Bake in pan and flip it!");
        }

        public override Pancake GetPancake()
        {
            return pancake;
        }

        public override void PrepareDough()
        {
            pancake.AddStep("Mix flour, eggs, milk, blueberry, suggar...");
        }
    }
}

