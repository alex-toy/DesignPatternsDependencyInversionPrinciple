using NotLSPLibrary;

Employee ceo = new CEO();
ceo.FirstName = "Tim";
ceo.LastName = "Corey";
ceo.CalculatePerHourRate(2);
Console.WriteLine($"{ ceo.FirstName }'s salary is ${ ceo.Salary }/hour.");

Employee accountingVP = new Manager();
accountingVP.FirstName = "Emma";
accountingVP.LastName = "Stone";
accountingVP.AssignManager(ceo);
Console.WriteLine($"{accountingVP.FirstName}'s manager is ${accountingVP.Manager.FirstName} {accountingVP.Manager.LastName}.");
accountingVP.CalculatePerHourRate(4);

Console.ReadLine();