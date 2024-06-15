var age = 33;
var name = "Eva";
var gender = "frau";

if (age < 30 && gender == "frau")
{
    Console.WriteLine("Diese Frau ist junger als 30");
}

else if (name == "Eva" && age == 33)

{
    Console.WriteLine("Eva, lat 33");
}
else if (gender != "frau" && age < 18)
{
    Console.WriteLine("Ein Mann unter 18 Jahre");
}
