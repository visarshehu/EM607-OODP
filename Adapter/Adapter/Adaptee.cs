using System;
namespace Adapter
{
	public class Adaptee
	{
		public Adaptee()
		{
		}

		public string GetCVS()
		{
			StreamReader sr = new StreamReader("/Users/visarshehu/test.txt");
			return sr.ReadToEnd();
		}
	}
}

