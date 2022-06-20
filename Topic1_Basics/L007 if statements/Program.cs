int nelyginisSkaicius = 5;
int lyginisSkaicius = 2;
bool tiesa = true;

// IF -------------------------------------------------------------------------------------------------------------------------------
if (nelyginisSkaicius > lyginisSkaicius)
{
    Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginisSkaicius}");
}

if (nelyginisSkaicius < lyginisSkaicius)
{
    Console.WriteLine($"{nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius}");
}


// IF ELSE --------------------------------------------------------------------------------------------------------------------------
if (nelyginisSkaicius < lyginisSkaicius)
{
    Console.WriteLine($"{nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius}");
}
else
{
    Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginisSkaicius}");
}


// IF ELSE IF ELSE ------------------------------------------------------------------------------------------------------------------
if (nelyginisSkaicius < lyginisSkaicius && tiesa)
{
    Console.WriteLine($"{nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius} ir tiesa yra true");
}
else if (nelyginisSkaicius < lyginisSkaicius && !tiesa)
{
    Console.WriteLine($"{nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius} ir tiesa yra false");
}
else if (nelyginisSkaicius > lyginisSkaicius && tiesa)
{
    Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginisSkaicius} ir tiesa yra true");
}
else
{
    Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginisSkaicius} ir tiesa yra false");
}

var score = 45;
int pointsNeededToPass = 100;
bool levelComplete = false;

//if (score >= pointsNeededToPass)
//{
//    levelComplete = true;
//}
//      //else
//      //{
//      //    levelComplete = false;
//      //}

//if (levelComplete)
//{
//    Console.WriteLine("valio!");
//}

Console.WriteLine(score >= pointsNeededToPass ? "valio" : "banky dar karta");




// IF { IF IF }         // IF KOMPOZICIJA           // NESTING ----------------------------------------------------------------------
int shields = 2;
int armor = 1;

if (shields <= 0)
{
    if (armor <= 0)
        Console.WriteLine("dead");
    else
        Console.WriteLine("still got armor");
}
else
{
    Console.WriteLine("still got shield");
}




// NULL-coalascing operator ---------------------------------------------------------------------------------------------------------
bool? nullableBool = true;
bool normalBool;

//normalBool = nullableBool;                // taip negalima!
normalBool = nullableBool ?? false;         // normalBool priskiria nullableBool jei jis nera null, jeigu yra, tai priskiria false reiksme
nullableBool ??= false;                     // patikriname ar pats nullableBool yra null ir jei taip yra ji keiciame i false












