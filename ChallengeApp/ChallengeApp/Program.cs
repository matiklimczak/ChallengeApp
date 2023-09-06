var age = 33;
var name = "Ewa";
var gender = "kobieta";

if (age < 30 && gender == "kobieta")
{
    Console.WriteLine("Kobieta poniezj 30 lat");
}

else if (name == "Ewa" && age == 33)

{
    Console.WriteLine("Ewa, lat 33");
}
else if (gender != "kobieta" && age < 18)
{
    Console.WriteLine("Niepelnoletni Mezczyzna");
}
