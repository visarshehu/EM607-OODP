using System;
namespace BuilderPattern
{
	public abstract class Pancake
	{
		private List<string> steps = new List<string>();

		public void AddStep(string step)
		{
			steps.Add(step);
		}

		public void ShowRecipe()
		{
			Console.WriteLine("The recipe for this pancake is:");
			foreach (var step in steps)
				Console.WriteLine(step);
		}
	}
}

