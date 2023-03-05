using LSPLibrary;

Manager accountingVP = new Manager();

accountingVP.FirstName = "Emma";
accountingVP.LastName = "Stone";
accountingVP.CalculatePerHourRate(4);

Employee emp = new CEO();

emp.FirstName = "Tim";
emp.LastName = "Corey";
emp.AssignManager(accountingVP);
emp.CalculatePerHourRate(2);

Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");

Console.ReadLine();