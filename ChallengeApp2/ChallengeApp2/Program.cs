using ChallengeApp2;
using System.Threading.Channels;

Console.WriteLine("Program do oceny pracownika");
Console.WriteLine("===========================");
Console.WriteLine();

var employee = new Employee("Adam", "Nowak");

while (true)
{
    Console.WriteLine("Podaj ocenę praownika");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"AVG :{statistics.Average}");
Console.WriteLine($"Min :{statistics.Min}");
Console.WriteLine($"Max :{statistics.Max}");
