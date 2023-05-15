using ChallengeApp2;

Employee employee1 = new("Adam", "qwerty");
Employee employee2 = new("Karol", "qwerty");
Employee employee3 = new("Tomek", "qwerty");

employee1.AddScore(11);
employee1.AddScore(-1);
employee1.AddScore(-1);

employee2.AddScore(2);
employee2.AddScore(2);
employee2.AddScore(2);

employee3.AddScore(3);
employee3.AddScore(3);
employee3.AddScore(3);

#region
List<Employee> users = new()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee userWitchMaxResult = null;

foreach (var user in users)
{
    if (user.Result > maxResult)
    {
        userWitchMaxResult = user;
        maxResult = userWitchMaxResult.Result;
    }
}
Console.WriteLine(userWitchMaxResult.Login + " zdobył największą liczbę ocen - " + userWitchMaxResult.Result);

#endregion

//#region
//if (employee1.Result > employee2.Result)
//{
//    if (employee1.Result > employee3.Result)
//    {
//        Console.WriteLine(employee1.Login + " zdobył " + employee1.Result + " punktów");
//    }
//    else
//    {
//        Console.WriteLine(employee3.Login + " zdobył " + employee3.Result + " punktów");
//    }
//}
//else
//{
//    Console.WriteLine(employee2.Login + " zdobył " + employee2.Result + " punktów");
//}
//#endregion