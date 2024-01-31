bool isWoman = true;
int age = 18;
string name = "Ewa";

if (isWoman == true && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if(!isWoman == false && age < 18)
{
    Console.WriteLine("Niepełnoletni meżczyzna");
}
else
{
    Console.WriteLine("Nic");
}
