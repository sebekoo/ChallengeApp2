var name = "Ewa";
char sex = 'm';
int age = 22;

if (sex == 'k')
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else if (sex == 'k' && age <= 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        Console.WriteLine("Kobieta");
    }
}
else if (age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Pełnoletni mężczyzna");
}