#region Tablice
// nowa tablica
string[] miasta = new string[3];
miasta[0] = "Kalisz";
miasta[1] = "Zduny";
miasta[2] = "Winiary";

Console.WriteLine(miasta[1]);
Console.WriteLine();

// nowa tablica
int[] grades = new int[3];
Console.WriteLine($"Długość tablicy grades {grades.Length}");

// nowa tablica
string[] dniTygodnia = new string[3];
Console.WriteLine($"Długość tablicy dniTygodnia {dniTygodnia.Length}");

dniTygodnia[0] = "pn";
dniTygodnia[1] = "wt";
dniTygodnia[2] = "sr";

for (int d = 0; d < dniTygodnia.Length; d++)
{
    Console.WriteLine($"Pętla for {d}");
    Console.WriteLine($"Element nr {d + 1} z listy posiada nazwe {dniTygodnia[d]}");
}
Console.WriteLine();
Console.WriteLine($"Tablica pętli \"foreach\"");

foreach (string d in dniTygodnia)
{
    Console.WriteLine(d);
}
Console.WriteLine(dniTygodnia[0]);

// nowa tablica w postaci string-u
string tekst = "Przykładowy tekst w tablicy";
Console.WriteLine(tekst[4]);

#endregion

#region Listy
Console.WriteLine();
Console.WriteLine("-+-+-+-+ Listy +-+-+-+-");
Console.WriteLine();
// nowa lista 
List<string> dayOfWeeks = new List<string>
{
    "Poniedzałek",
    "Wtorek",
    "Środa",
    "Czwartek",
    "Piątek",
    "Sobota",
    "Niedziela"
};

Console.WriteLine($"Wielkość listy dayOfWeeks {dayOfWeeks.Count}");

// nowa lista 
List<char> alfabet = new List<char>
{
    'a','ą','b','c','ć','d','e','ę','f','g','h','i','j','k','l','ł','m','n','ń','o','ó','p','r','s','ś','t','u','v','w','z','ź','ż'
};

Console.WriteLine($"Ilość liter w alfabecie {alfabet.Count}");

for (int j = 0; j < alfabet.Count; j += 4) //zamiast j += 2 można użyć j = j + 2
{
    Console.WriteLine(alfabet[j]);
}

// nowa lista 
string[] dayOfWeeks2 = { "Poniedzałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela" };
Console.WriteLine($"Wielkość tablicy dayOfWeeks2 {dayOfWeeks2.Length}");

for (int i = 0; i < dayOfWeeks2.Length; i++)
{
    Console.WriteLine($"Elementy tablicy dayOfWeeks2 {dayOfWeeks2[i]}");
}
Console.WriteLine(dayOfWeeks.Count);
Console.WriteLine(dayOfWeeks2[0]);

// nowa lista 
List<string> dayOfWeek = new List<string>
{
    "Pn",
    "Wt",
    "Śr",
    "Cz",
};

Console.WriteLine("Lista z pętli \"for\"");
for (int z = 0; z < dayOfWeek.Count; z++)
{
    Console.WriteLine(dayOfWeek[z]);
}
// lub "foreach"
Console.WriteLine($"Lista z pętli \"foreach\"");
foreach (string day in dayOfWeek)
{
    Console.WriteLine(day);
}

Console.WriteLine($"Wielkość tablicy dayOfWeek {dayOfWeek.Count}");

// nowa lista 
List<int> cyfry = new List<int> {  };
var size = cyfry.Capacity;
Console.WriteLine($"Początkowy rozmiar listy: {size}");
Console.WriteLine($"Początkowy pojemność listy {cyfry.Capacity}");

for (var i = 0; i < 12; i++)
{
    cyfry.Add(i);
    if (cyfry.Capacity != size)
    {
        size = cyfry.Capacity;
        Console.WriteLine($"Zmiana rozmiaru na: {size} przy {cyfry.Count} elementach");
    }
}

Console.WriteLine($"Ilość elementów tablicy {cyfry.Count}");
for (int x = 0; x < cyfry.Count; x++)
{
    Console.WriteLine(x);
}

foreach (int z in cyfry)
{
    Console.WriteLine(z);
}
Console.WriteLine();

// nowa lista 
List<string> wies = new List<string>()
{
    "Zawady", "Szałe", "Wygoda"
};

Console.WriteLine(wies[1]);

#endregion

#region Zadanie domowe

int number = 937;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToCharArray();
int[] digit = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

Console.WriteLine("Pętla for");
Console.WriteLine();
for (int i = 0; i < 10; i++)
{
    int counter = 0;
    foreach (char letter in letters)
    {
        if (int.Parse(letter.ToString()) == i)
        {
            counter++;
        }
    }
    Console.WriteLine(i + " => " + counter);
}

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

Console.WriteLine();
Console.WriteLine("Pętla foreach");
Console.WriteLine();

foreach (char letter in letters)
{
    if (letter == '0')
    {
        counter0++;
    }
    else if (letter == '1')
    {
        counter1++;
    }
    else if (letter == '2')
    {
        counter2++;
    }
    else if (letter == '3')
    {
        counter3++;
    }
    else if (letter == '4')
    {
        counter4++;
    }
    else if (letter == '5')
    {
        counter5++;
    }
    else if (letter == '6')
    {
        counter6++;
    }
    else if (letter == '7')
    {
        counter7++;
    }
    else if (letter == '8')
    {
        counter8++;
    }
    else
    {
        counter9++;
    }
}

Console.WriteLine($"0 => {counter0}");
Console.WriteLine($"1 => {counter1}");
Console.WriteLine($"2 => {counter2}");
Console.WriteLine($"3 => {counter3}");
Console.WriteLine($"4 => {counter4}");
Console.WriteLine($"5 => {counter5}");
Console.WriteLine($"6 => {counter6}");
Console.WriteLine($"7 => {counter7}");
Console.WriteLine($"8 => {counter8}");
Console.WriteLine($"9 => {counter9}");
Console.WriteLine();
Console.WriteLine("Osobno pętle foreach i for");
Console.WriteLine();

foreach (char i in letters)
{
    digit[i - '0']++;
}
for (int j = 0; j < 10; j++)
{
    Console.WriteLine(j + " => " + digit[j]);
}
#endregion