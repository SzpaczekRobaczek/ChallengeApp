using Challenge21;

Console.WriteLine("Witam i o zdrowie pytam");
Console.WriteLine("");
Console.WriteLine("Napisz q jak chcesz zobaczyć statystyki");
Console.WriteLine("");

var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocene pracownika:");
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
        Console.WriteLine($"Excepiton catched: {ex.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");










