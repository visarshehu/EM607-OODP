using System;
namespace Prototype
{
	public class CrabInvader : SpaceInvader
	{
		public CrabInvader()
		{
            this.AlienType = "Crab";
            this.health = 10;
		}

        public override SpaceInvader Clone()
        {
            return (SpaceInvader)this.MemberwiseClone();
        }
    }
}

