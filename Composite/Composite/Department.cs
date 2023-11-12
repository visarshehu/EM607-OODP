using System;
namespace Composite
{
	public class Department : IOrganizationComponent
	{
        private string _name;

        private List<IOrganizationComponent> components =
            new List<IOrganizationComponent>();

		public Department(string name)
		{
            _name = name;
		}

        public void Add(IOrganizationComponent newComponent)
        {
            components.Add(newComponent);
        }

       public void DisplayDetails()
        {
            Console.WriteLine("Department: " + _name);
            foreach (var c in components)
            {
                c.DisplayDetails();
            }
        }
    }
}

