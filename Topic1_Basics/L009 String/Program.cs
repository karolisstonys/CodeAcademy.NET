Console.WriteLine("String manipuliacijos");


//==================================================================================
Console.WriteLine();
Console.WriteLine(" < < < < string constructor > > > > ");
char[] letters = { 'H', 'e', 'l', 'l', 'o' };   // array

string greetings = new string(letters); // string constructor

Console.WriteLine(letters[0]);
Console.WriteLine(greetings);


//==================================================================================
Console.WriteLine();
Console.WriteLine("=================== string concatination ===================");
string name = "Jhonny";
var fullName = name + " SURENAME";
Console.WriteLine(fullName);


//==================================================================================
Console.WriteLine();
Console.WriteLine("=================== string composition ===================");
DateTime today = DateTime.Today;
var nameAndDate = string.Format("{0} date - {1}", name, today);
Console.WriteLine(nameAndDate);


//==================================================================================
Console.WriteLine();
Console.WriteLine("=================== string interpolation ===================");
var nameAndDate1 = string.Format($"{name} date - {today}");
Console.WriteLine(nameAndDate1);


//==================================================================================
Console.WriteLine();
Console.WriteLine("=================== Possible empty strings ===================");
string? nullableString = null;
string emptyString = "";                // same thing (1)
string emptyString1 = string.Empty;     // same thing (2)

string whiteSpace = "     ";
Console.WriteLine($"is \"\" string.Empty? {emptyString == emptyString1}");

bool isNullableStringEmpty = string.IsNullOrEmpty(nullableString);
Console.WriteLine($"is nullableString string.IsNullOrEmpty? {isNullableStringEmpty}");

bool isEmptyStringEmpty = string.IsNullOrEmpty(emptyString);
Console.WriteLine($"is emptyString string.IsNullOrEmpty? {isEmptyStringEmpty}");

bool isWhiteSpaceEmpty = string.IsNullOrEmpty(whiteSpace);
Console.WriteLine($"is whiteSpace string.IsNullOrEmpty? {isWhiteSpaceEmpty}");

bool isWhiteSpace = string.IsNullOrWhiteSpace(whiteSpace);
Console.WriteLine($"is whiteSpace string.IsNullOrWhiteSpace? {isWhiteSpace}");


//==================================================================================
Console.WriteLine();
Console.WriteLine("=================== Escapes ===================");
string a1 = "aaaa \"";
string a2 = "aaaa \\";

string a3 = "aaaa \n";  // nera rekomenduojama, new skirtingos OS \n supranta skirtingai. Visos turi savo 'naujos eilutes' komandas.
string a4 = $"aaaa {Environment.NewLine} bbbb";

string a5 = "kelias diske - c:\\program files\\ABC";    // nera rekomenduojama, yra geresnis variantas - {Path.DirectorySeparatorChar} 
string a6 = $"kelias diske - c:{Path.DirectorySeparatorChar}program files{Path.DirectorySeparatorChar}ABC";

string a7 = $"{{aaaaa}}";   // { escape is {

string a8 = @"
multiline text
special simbols does not need escapes \ { @
to escape --->""<--- just type it twice
";


//==================================================================================
Console.WriteLine();
Console.WriteLine("=================== Shortening a number (with ROUNDING) ===================");

double number = 6.6543219999999;
string numberShorter = number.ToString("0.00");         // ROUNDING !!!
Console.WriteLine(numberShorter);




//==================================================================================
















































