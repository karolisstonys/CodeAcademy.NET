
//(https://www.tutorialspoint.com/compound-assignment-operators-in-chash)
// ====================================
// priskyrimo operatoriai ( += -= *= /= ) COMPOUND


int skaicius;
int kitasSkaicius = 20;
skaicius = 10;
kitasSkaicius = skaicius;

Console.WriteLine($"skaicius = {skaicius};");
Console.WriteLine($"kitasSaicius = {kitasSkaicius}");
Console.WriteLine($"kitasSaicius = skaicius; kitasSaicius = {kitasSkaicius}");

int nelyginisSkaicius = 5;
Console.WriteLine($"nelyginisSkaicius = {nelyginisSkaicius};");

kitasSkaicius += nelyginisSkaicius;          // C += A    -->    C = C + A
Console.WriteLine($"kitasSaicius += nelyginisSkaicius; kitasSaicius = {kitasSkaicius}");

kitasSkaicius -= nelyginisSkaicius;
Console.WriteLine($"kitasSaicius -= nelyginisSkaicius; kitasSaicius = {kitasSkaicius}");

kitasSkaicius *= nelyginisSkaicius;
Console.WriteLine($"kitasSaicius *= nelyginisSkaicius; kitasSaicius = {kitasSkaicius}");

kitasSkaicius /= nelyginisSkaicius;
Console.WriteLine($"kitasSaicius *= nelyginisSkaicius; kitasSaicius = {kitasSkaicius}");

double doubleSkaicius = 21;
doubleSkaicius /= nelyginisSkaicius;        // INPLICIT CAST    ->    doubleSkaicius /= (double)nelyginisSkaicius
Console.WriteLine($"doubleSkaicius /= nelyginisSkaicius; doubleSkaicius = {doubleSkaicius}");


// ==========================================
// matematiniai operatoriai ( + - * / % ++ -- )

int suma = skaicius + kitasSkaicius;
Console.WriteLine("   suma = skaicius+kitasSkaicius = {0}", suma);
int atimtis = skaicius - kitasSkaicius;
Console.WriteLine("   atimtis = skaicius-kitasSkaicius = {0}", atimtis);
int daugyba = skaicius * kitasSkaicius;
Console.WriteLine("   daugyba = skaicius*kitasSkaicius = {0}", daugyba);
double dalyba = (double)skaicius / kitasSkaicius;
Console.WriteLine("   dalyba = skaicius/kitasSkaicius = {0}", dalyba);

int matematinisRezultatas = 1 + 2 - 3 + 4 + nelyginisSkaicius - skaicius;

int dalybaSuLiekana = nelyginisSkaicius % 2;
Console.WriteLine("   dalybaSuLiekana = nelyginisSkaicius % 2 = {0}", dalybaSuLiekana);

skaicius++;
Console.WriteLine($"   skaicius={skaicius}");

skaicius--;
Console.WriteLine($"   skaicius={skaicius}");





// Overflow & Underflow

short s1 = 30_000;
short s2 = 30_000;
short s3 = (short)(s1 + s2);

Console.WriteLine($"s1 + s2 = s3  - {s1 + s2}");






