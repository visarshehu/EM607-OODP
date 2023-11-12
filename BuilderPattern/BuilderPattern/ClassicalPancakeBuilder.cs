using System;
namespace BuilderPattern
{
    public class ClassicalPancakeBuilder : PancakeBuilder
    {
        Pancake pancake = new ClassicalPancake();

        public override void AddTopping()
        {
            pancake.AddStep("Add mapple surup!");
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
            pancake.AddStep("Mix flour, eggs, milk, suggar...");
        }
    }
}

