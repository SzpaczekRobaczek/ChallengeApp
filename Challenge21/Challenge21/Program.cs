using Challenge21;

Console.WriteLine("Witam i o zdrowie pytam");
Console.WriteLine("");
Console.WriteLine("Napisz q jak chcesz zobaczyć statystyki");
Console.WriteLine("");

var employee = new Employee();

Console.WriteLine("Podaj pierwszą ocene pracownika:");
var input = Console.ReadLine();

employee.AddGrade(input);

while (true)
{
    Console.WriteLine("Podaj kolejną ocene pracownika:");
    var input2 = Console.ReadLine();
    if (input2 == "q")
    {
        break;
    }
    employee.AddGrade(input2);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");










