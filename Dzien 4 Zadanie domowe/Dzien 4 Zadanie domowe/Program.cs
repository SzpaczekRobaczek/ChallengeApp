var name = "Ania";
var sex = "Female";
var age = 50;

Console.WriteLine("Rozwiazanie");

if (sex == "Female" && age > 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (age > 18 && sex == "Male")
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Przypal");
}


