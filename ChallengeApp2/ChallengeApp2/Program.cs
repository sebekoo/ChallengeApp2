using ChallengeApp2;

var employee = new Employee("Adam", "Nowak");
//employee.AddGrade("Adam");
//employee.AddGrade("5");
//employee.AddGrade(2f);
employee.AddGrade(6d);
var statistics = employee.GetStatisticsWithForEach();

Console.WriteLine("forEach");
Console.WriteLine($"Average : {statistics.Average:N2}");
Console.WriteLine($"Min     : {statistics.Min}");
Console.WriteLine($"Max     : {statistics.Max}");
Console.WriteLine("");
var statistics2 = employee.GetStatisticsWithFor();

Console.WriteLine("for");
Console.WriteLine($"Average : {statistics.Average:N2}");
Console.WriteLine($"Min     : {statistics.Min}");
Console.WriteLine($"Max     : {statistics.Max}");
Console.WriteLine("");
var statistics3 = employee.GetStatisticsWithWhile();

Console.WriteLine("while");
Console.WriteLine($"Average : {statistics.Average:N2}");
Console.WriteLine($"Min     : {statistics.Min}");
Console.WriteLine($"Max     : {statistics.Max}");
Console.WriteLine("");
var statistics4 = employee.GetStatisticsWithDoWhile();

Console.WriteLine("doWhile");
Console.WriteLine($"Average : {statistics.Average:N2}");
Console.WriteLine($"Min     : {statistics.Min}");
Console.WriteLine($"Max     : {statistics.Max}");