string name = "Ewa";
    string sex = "Female";
    int age = 33;
if (name == "Ewa" && age == 33){
    Console.WriteLine("Ewa, lat 33");
}
else if (sex != "Female" && age == 18)
{
    Console.WriteLine("niepełnoletni mężczyna");
}
if (age < 30 && sex == "Female")
{
    Console.WriteLine("kobieta poniżej 30 lat");
}