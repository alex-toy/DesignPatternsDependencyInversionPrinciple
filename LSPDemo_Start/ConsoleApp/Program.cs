using LSPLibrary;

IManager ceo = new CEO();
ceo.FirstName = "Tim";
ceo.LastName = "Corey";
//ceo.AssignManager(new Employee());
ceo.CalculatePerHourRate(2);
Console.WriteLine($"{ ceo.FirstName }'s salary is ${ ceo.Salary }/hour.");

IManaged manager = new Manager();
manager.FirstName = "Emma";
manager.LastName = "Stone";
manager.AssignManager(ceo);
Console.WriteLine($"{manager.FirstName}'s manager is ${manager.Manager.FirstName} {manager.Manager.LastName}.");
manager.CalculatePerHourRate(4);

IManaged employee = new Employee();
employee.FirstName = "alex";
employee.LastName = "reaktor";
employee.AssignManager(manager);
Console.WriteLine($"{employee.FirstName}'s manager is ${employee.Manager.FirstName} {employee.Manager.LastName}.");
employee.CalculatePerHourRate(4);

Console.ReadLine();





//using NotLSPLibrary;

//Employee ceo = new CEO();
//ceo.FirstName = "Tim";
//ceo.LastName = "Corey";
//ceo.AssignManager(new Employee());
//ceo.CalculatePerHourRate(2);
//Console.WriteLine($"{ ceo.FirstName }'s salary is ${ ceo.Salary }/hour.");

//Employee accountingVP = new Manager();
//accountingVP.FirstName = "Emma";
//accountingVP.LastName = "Stone";
//accountingVP.AssignManager(ceo);
//Console.WriteLine($"{accountingVP.FirstName}'s manager is ${accountingVP.Manager.FirstName} {accountingVP.Manager.LastName}.");
//accountingVP.CalculatePerHourRate(4);

//Console.ReadLine();