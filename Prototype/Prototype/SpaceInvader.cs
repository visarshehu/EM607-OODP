using System;
namespace Prototype
{
	public abstract class SpaceInvader
	{
		protected int health;
		public string AlienType { get; set; }

		public abstract SpaceInvader Clone();

		public void Hit(int damage)
		{
			health = health - damage;
			if (health <= 0)
			{
				Console.WriteLine(AlienType + " was destroyed!");
			}
			else
			{
				Console.WriteLine(AlienType + " took" + damage + " damage!");
			}
		}

	}
}

