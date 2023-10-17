// Tablice
Console.WriteLine("Tablice");
Console.WriteLine("");
int[] grades = new int[365];

string[] dayOfWeeks = new string[7]; // 7 odnosi się to ilości komorek w tabeli, tabela czyna się od 0
dayOfWeeks[0] = "poniedziałek";
dayOfWeeks[1] = "wtorek";
dayOfWeeks[2] = "środa";
dayOfWeeks[3] = "czwartek";
dayOfWeeks[4] = "piątek";
dayOfWeeks[5] = "sobota";
dayOfWeeks[6] = "niedziela";
Console.WriteLine(dayOfWeeks[3]);

string[] dayOfWeeks2 = { "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };
Console.WriteLine(dayOfWeeks2[5]);

Console.WriteLine("");
Console.WriteLine("Pętla for");
Console.WriteLine("");
// Pętla "for"
// wartość poczatkowa i=0 - początek pętli zaczyna sie od 0
// petla rosnie i<=10 - koniec pętli jest na 10
// pętla rośnie o wartosć i=i+1 albo i++ - pętla wzrasta o podana wartosc w tym przypadku o 1
for (int i = 0; i <= 10; i = i + 1) // moze tez napisac i++ w ostatnim
{
    Console.WriteLine(i);
}
Console.WriteLine("");
Console.WriteLine("Polaczenie tabeli i pętli");
Console.WriteLine("");
// Połączenie tablic i pętli for

for (int i = 0; i < 7; i = i + 2)
{
    Console.WriteLine(dayOfWeeks[i]);
}

for (int i = 0; i < dayOfWeeks.Length; i = i + 1)
{
    Console.WriteLine(dayOfWeeks[i]);
}

Console.WriteLine("");
Console.WriteLine("Lista");
Console.WriteLine("");
// Listy - tabele na "sterydach"

List<string> dayOfWeeks3 = new List<string>();
dayOfWeeks3.Add("poniedziałek");
dayOfWeeks3.Add("wtorek");
dayOfWeeks3.Add("środa");
dayOfWeeks3.Add("czwartek");
dayOfWeeks3.Add("piątek");
dayOfWeeks3.Add("sobota");
dayOfWeeks3.Add("niedziela");

for (int i = 0; i < dayOfWeeks3.Count; i = i + 1) // "Count" dla List, "Length" dla Tabeli
{
    Console.WriteLine(dayOfWeeks3[i]);
}

Console.WriteLine("");
Console.WriteLine("Pętla foreacha");
Console.WriteLine("");
//Pętla foreach

List<string> dayOfWeeks4 = new List<string>();
dayOfWeeks4.Add("poniedziałek");
dayOfWeeks4.Add("wtorek");
dayOfWeeks4.Add("środa");
dayOfWeeks4.Add("czwartek");
dayOfWeeks4.Add("piątek");
dayOfWeeks4.Add("sobota");
dayOfWeeks4.Add("niedziela");

foreach(var day in dayOfWeeks4)
{
    Console.WriteLine(day);
}