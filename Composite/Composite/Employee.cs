using System;
namespace Composite
{
	public class Employee : IOrganizationComponent
	{
        private string _name;

		public Employee(string name)
		{
            _name = name;
		}

        public void DisplayDetails()
        {
            Console.WriteLine("Employee: " + _name);
        }
    }
}

