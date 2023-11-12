using Prototype;

CrabInvader crabInvader = new CrabInvader();
ScorpionInvader scorpionInvader = new ScorpionInvader();


List<SpaceInvader> allInvaders = new List<SpaceInvader>();
for (int i= 0; i < 100; i++)
{
    SpaceInvader si;
    if (i % 2 == 0)
    {
        si = crabInvader.Clone();
    }
    else
    {
        si = scorpionInvader.Clone();
    }
    allInvaders.Add(si);
}

foreach (SpaceInvader si in allInvaders)
{
    Random r = new Random();
    si.Hit(r.Next(1, 15));
}