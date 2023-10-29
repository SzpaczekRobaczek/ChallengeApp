using Challenge21;

var employee = new Employee("Adam", "Lewandowski");
employee.AddGrade(4);
employee.AddGrade("10");
employee.AddGrade(5);
employee.AddGrade(4);

//var statistics = employee.GetStatistics();

Console.WriteLine("Statystyka z ForEach");
var statistics1 = employee.GetStatisticsWithForEach();

Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");

Console.WriteLine("");
Console.WriteLine("Statystyka z DoWhile");
var statistics2 = employee.GetStatisticsWithDoWhile();

Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

Console.WriteLine("");
Console.WriteLine("Statystyka z While");
var statistics3 = employee.GetStatisticsWithWhile();

Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");

Console.WriteLine("");
Console.WriteLine("Statystyka z For");
var statistics4 = employee.GetStatisticsWithFor();

Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");








