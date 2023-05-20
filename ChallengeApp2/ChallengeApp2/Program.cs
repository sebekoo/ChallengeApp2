using ChallengeApp2;
using System.Threading.Channels;

Console.WriteLine("Program do oceny pracownika");
Console.WriteLine("===========================");
Console.WriteLine();

var employee = new Employee();

//try
//{
//    Employee emp = null;
//    var name = emp.Name;
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Błąd w programie nie podano imienia : " + ex.Message);
//}
//finally
//{
//    Console.WriteLine("Finally here");
//}

while (true)
{
    Console.WriteLine("Podaj ocenę praownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Exception cached: " + ex.Message);
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"AVG :{statistics.Average}");
Console.WriteLine($"Min :{statistics.Min}");
Console.WriteLine($"Max :{statistics.Max}");
