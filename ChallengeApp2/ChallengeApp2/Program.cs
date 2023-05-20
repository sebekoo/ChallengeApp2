using ChallengeApp2;

Console.WriteLine("Program do oceny pracownika");
Console.WriteLine("===========================");
Console.WriteLine();

//var employee = new Employee("Adamek", "Atomek");
//var employee1 = new Supervisor("Adamek", "Atomek");
var employee1 = new EmployeeInFile("Adamek", "Atomek");


// !!!  Zakomentuj trzy linie poniżej aby odczytać z pliku !!!
//employee1.AddGrade(0.5f);
//employee1.AddGrade(34);
//employee1.AddGrade('c');


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

//while (true)
//{
//    Console.WriteLine("Podaj ocenę praownika");
//    var input = Console.ReadLine();
//    if (input == "q")
//    {
//        break;
//    }

//    try
//    {
//        //employee.AddGrade(input);
//        employee1.AddGrade(input);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Exception cached: " + ex.Message);
//    }
//}

//var statistics = employee.GetStatistics();
var statistics = employee1.GetStatistics();
Console.WriteLine($"AVG       : {statistics.Average}");
Console.WriteLine($"Min       : {statistics.Min}");
Console.WriteLine($"Max       : {statistics.Max}");
Console.WriteLine($"AVGLetter : {statistics.AverageLetter}");
