

Console.Write("Iveskite meniu punkta: ");

int menuChoice = Convert.ToInt32(Console.ReadLine());

switch (menuChoice)
{
    case 1:
        Console.WriteLine("vartotojas pasirinko 1");
        break;
    case 2:
        Console.WriteLine("vartotojas pasirinko 2");
        break;
    case 3:
        Console.WriteLine("vartotojas pasirinko 3");
        break;
    default:
        Console.WriteLine("pasirinkimas negalimas");
        break;
}

Console.WriteLine("------------------------------------");

var isvadamasRezultatas = menuChoice switch
{
    1 => "vartotojas pasirinko 1",
    2 => "vartotojas pasirinko 2",
    3 => "vartotojas pasirinko 3",
    _ => "vartotojas nieko nepasirinko"
};
Console.WriteLine(isvadamasRezultatas);



// ==================================================================================


Console.WriteLine("------------------------------------");


switch (menuChoice)
{
    case 1:
    case 2:
        Console.WriteLine("vartotojas pasirinko 1 arba 2");
        break;
}



































