using Composite;

Employee john = new Employee("John Doe");
Employee jane = new Employee("Jane Doe");
Employee visar = new Employee("Visar shehu");

Department sales = new Department("Sales department");
sales.Add(john);
sales.Add(jane);

Department development = new Department("Development");
development.Add(visar);

Employee designer = new Employee("Some Designer");
Department design = new Department("DEsign");
design.Add(designer);

development.Add(design);

Department organization = new Department("Entire organization");
organization.Add(sales);
organization.Add(development);

organization.DisplayDetails();
