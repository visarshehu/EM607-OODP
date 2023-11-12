using System;
namespace Prototype
{
	public class ScorpionInvader : SpaceInvader
	{
		public ScorpionInvader()
		{
            this.AlienType = "Scorpion";
            this.health = 10;
        }

        public override SpaceInvader Clone()
        {
            return (SpaceInvader)this.MemberwiseClone();
        }
    }
}

