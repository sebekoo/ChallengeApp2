using ChallengeApp2;

var employee = new Employee("Adam", "Nowak");
employee.AddGrade("Adam");
employee.AddGrade("5");
employee.AddGrade(2f);
employee.AddGrade(6d);
var statistics = employee.GetStatistics();


Console.WriteLine($"Average : {statistics.Average:N2}");
Console.WriteLine($"Min     : {statistics.Min}");
Console.WriteLine($"Max     : {statistics.Max}");