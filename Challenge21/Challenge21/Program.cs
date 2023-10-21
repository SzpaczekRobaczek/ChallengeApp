using Challenge21;

Employee employee1 = new Employee("Adam", "Kowalski");
Employee employee2 = new Employee("Monika", "Lewandowska");
Employee employee3 = new Employee("Zuzia", "Nowak");

employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(1);
employee1.AddScore(1);
employee1.AddScore(6);

employee2.AddScore(6);
employee2.AddScore(6);
employee2.AddScore(6);
employee2.AddScore(7);
employee2.AddScore(9);

employee3.AddScore(9);
employee3.AddScore(10);
employee3.AddScore(6);
employee3.AddScore(10);
employee3.AddScore(9);

var result1 = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;


Console.WriteLine("Zadanie domowe dzień 6");
Console.WriteLine("Osoba z największą liczbą punktów to:");

if (result1 > result2 && result1 > result3)
{
    Console.WriteLine(employee1.Name + " " + employee1.Surname + " posiada: " + result1 + "pkt.");
}
else if (result2 > result1 && result2 > result3)
{
    Console.WriteLine(employee2.Name + " " + employee2.Surname +  " posiada: " + result2 + "pkt.");
}
else if (result3 > result2 && result3 > result1)
{
    Console.WriteLine(employee3.Name + " " + employee3.Surname + " posiada: " + result3 + "pkt.");
}





