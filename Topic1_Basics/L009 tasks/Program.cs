/*          
          AMŽIAUS MELAGIS
          Sukurkite programą, kuri pateiktų vartotojo registracijos formą.
          Vartotojas įveda:
            - vardą ir pavardę 
            - asmens kodą (11simb.)
            - amžių (sveiką skaičių metais) ir/arba gimimo datą (galima abu, tik kažkurį vieną, ar neįvesti nei vieno)
          Programa į ekraną išveda ataskatą:
           - šiandienos datą
           - Vardas, pavardė
           - Lytis
              <HINT> asmens kodo pirmasis rodo gimimo šimtmetį ir asmens lytį 
              (1 – XIX a. gimęs vyras, 
               2 – XIX a. gimusi moteris, 
               3 – XX a. gimęs vyras,
               4 – XX a. gimusi moteris, 
               5 – XXI a. gimęs vyras,
               6 – XXI a. gimusi moteris
               tolesni šeši: 
                    metai (du skaitmenys), 
                    mėnuo (du skaitmenys), 
                    diena (du skaitmenys))     
           - Asmens kodas 
              <NEPRIVALOMAS PASUNKINIMAS> asmens kodas validuojamas pagal tokias salygas
                 Paskaičiuojamas Kontrolinis skaičius 
                 a) jei kontrolinis skaičius teisingas išvedamas asmens kodas
                 b) jei neteisingas išvedamas tekstas "kodas neteisingas", 
                    o laukeAmžiaus patikimumas išvedama "patikimumui trūksta duomenų" 
                    <HINT> https://lt.wikipedia.org/wiki/Asmens_kodas
           - Amžius
           - Amžiaus patikimumas - pagal tokias sąlygas:
           -  jei įvestas amžius metais, paskaičiuoti gimimo metus ir sulyginti su įvestu asmens kodu. 
              a) jei sutampa išvesti "amžius patikimas"
              b) jei nesutampa išvesti "amžius pameluotas"
           - jei įvesta gimimo data sulyginti su įvestu asmens kodu. 
              a) jei sutampa išvesti "amžius patikimas" 
              b) jei nesutampa išvesti "amžius pameluotas"
           - jei įvesta ir amžius ir gimimo data sulyginti su įvestu asmens kodu. 
              a) jei viskas sutampa išvesti "amžius tikras" 
              b) jei asmens kodu sutampa tik vienas įvestų, išvesti "amžius nepatikimas" 
              c) jei nesutampa išvesti "amžius pameluotas"
           - jei neįvesta nei amžius nei gimimo data išvesti
              a) "patikimumui trūksta duomenų"

Rezultatas gali atrodyti taip:
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ ATASKAITA APIE ASMENĮ ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓      2022-06-20       ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓     Vardas, pavardė ▓ Vardenis Pavardenis                 ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓               Lytis ▓ Vyras                               ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓        Asmens kodas ▓ 44012029286                         ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓              Amžius ▓ 82                                  ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓         Gimimo data ▓ 1980-06-20                          ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓ Amžiaus patikimumas ▓ amžius nepatikimas                  ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
*/

DateTime today = DateTime.Now;
Console.Write("iveskite varda ir pavarde: ");
string name = Console.ReadLine();

Console.Write("iveskite asmens kodą (11simb.): ");
string code = Console.ReadLine();
string gender = "";

// TIKRINAMAS AR ASMENS KODAS IS 11 SIMBOLIU IR PARENKAMA LYTIS PAGAL PIRMA SKAICIU, JEI JIS ISVESTAS TEISINGAI
string code0 = Convert.ToString(code.Trim()[0]);
if (code.Length == 11 && (code0 == "1" || code0 == "3" || code0 == "5"))
{
    gender = "vyras";
}
else if (code.Length == 11 && (code0 == "2" || code0 == "4" || code0 == "6"))
{
    gender = "moteris";
}
else
{
    Console.WriteLine("- - - Blogai ivestas asmens kodas! - - -");
    Environment.Exit(0);
}

// VARTOTOJAS GALI IVESTI METUS IR/AR GIGIMO DATA I VIENA EILUTE ATSKIRIANT TARPU, EILISKUMAS NESVARBU, GALI NEVESTI IR NIEKO
Console.Write("jeigu norite įveskite savo metus ir/ar gimino datą: ");
string age = Console.ReadLine();
int ageYears = 0;
DateTime ageBirthDate = new DateTime();

// AR AGE NERA NULL ARBA TUSCIAS ARBA WHITESPACE
if (!(string.IsNullOrEmpty(age) || string.IsNullOrWhiteSpace(age)))
{
    // AR AGE TURI TARPA
    if (age.Contains(' '))
    {
        string[] ageSplit = age.Trim().Split(' ');

        bool isIntAgeSplit0 = int.TryParse(ageSplit[0], out int intAgeSplit0);
        bool isIntAgeSplit1 = int.TryParse(ageSplit[1], out int intAgeSplit1);

        bool isDateAgeSplit0 = DateTime.TryParse(ageSplit[0], out DateTime dateAgeSplit0);
        bool isDateAgeSplit1 = DateTime.TryParse(ageSplit[1], out DateTime dateAgeSplit1);
        
        // TIKRINAME KURI PERSKIRTA AGE DALIS YRA int IR ATITINKAMAI JA PRISKIRIAME ageYears        
        if (isIntAgeSplit0) 
            ageYears = intAgeSplit0;
        else
            ageYears = intAgeSplit1;

        // TIKRINAME KURI PERSKIRTA AGE DALIS YRA DateTime IR ATITINKAMAI JA PRISKIRIAME ageBirthDate
        if (isDateAgeSplit0)
            ageBirthDate = dateAgeSplit0;
        else
            ageBirthDate = dateAgeSplit1;
    }
    else
    {
        // JEIGU AGE NETURI TARPU, TAI NUMANOMA, KAD IVESTA TIK VIENAS PARAMETRAS (METAI arba GIMIMO DATA) (TUSCIAS PATIKRINTAS AUKSCIAU)
        bool isIntAge = int.TryParse(age, out int intAge);
        bool isDateAge = DateTime.TryParse(age, out DateTime dateAge);

        // JEI TAI NE MATAI, TAI LIEKA TIK GIMIMO DATA
        if (isIntAge)
            ageYears = intAge;
        else if (isDateAge)
            ageBirthDate = dateAge;
    }
}

string reliability = "";

// IŠ ASMENS KODO IŠSITRAUKIAME TIK GIMIMO METUS
int birthYearFromCode = Convert.ToInt32(code.Substring(1, 2));
if (code0 == "1" || code0 == "2")
    birthYearFromCode = 1800 + birthYearFromCode;
else if (code0 == "3" || code0 == "4")
    birthYearFromCode = 1900 + birthYearFromCode;
else if (code0 == "5" || code0 == "6")
    birthYearFromCode = 2000 + birthYearFromCode;

// IŠ ASMENS KODO IŠSITRAUKIAME PILNA GIMIMO DATA
string birthDateFromCode = birthYearFromCode + "-" + code.Substring(3, 2) + "-" + code.Substring(5, 2);

// IŠ PATEIKTO AMŽIAUS PASKAICIUOJAME GIMIMO METUS
int birthYear = today.AddYears(ageYears*-1).Year;

// JEIGU ĮVESTI TIK METAI
if (ageYears != 0 && ageBirthDate == new DateTime())
{
    if (birthYear == birthYearFromCode)
        reliability = "amžius patikimas";
    else
        reliability = "amžius pameluotas";
}
// JEIGU ĮVESTA TIK GIMIMO DATA
else if (ageYears == 0 && ageBirthDate != new DateTime())
{
    if (birthDateFromCode == ageBirthDate.ToString("yyyy-mm-dd"))
        reliability = "amžius patikimas";
    else
        reliability = "amžius pameluotas";
}
// JEIGU ĮVASTI IR METAI IR GIMIMO DATA
else if (ageYears != 0 && ageBirthDate != new DateTime())
{
    if (birthDateFromCode == ageBirthDate.ToString("yyyy-MM-dd") && birthYearFromCode == birthYear)
        reliability = "amžius tikras";
    else if (birthDateFromCode == ageBirthDate.ToString("yyyy-MM-dd") || birthYearFromCode == birthYear)
        reliability = "amžius nepatikimas";
    else
        reliability = "amžius pameluotas";
}
// NIEKAS NEĮVESTA
else if (ageYears == 0 && ageBirthDate == new DateTime())
{
    reliability = "patikimumui trūksta duomenų";
}

Console.WriteLine();
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ ATASKAITA APIE ASMENĮ ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓      {today.ToString("yyyy-MM-dd")}       ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓     Vardas, pavardė ▓ {name,-36}▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓               Lytis ▓ {gender,-36}▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓        Asmens kodas ▓ {code,-36}▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓              Amžius ▓ " + ((ageYears != 0) ? ageYears : "NEĮVESTA                            ▓"));
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓         Gimimo data ▓ " + ((ageBirthDate != new DateTime()) ? ageBirthDate.ToString("yyyy-MM-dd") + "                          ▓" : "NEĮVESTA                            ▓"));
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓ Amžiaus patikimumas ▓ {reliability,-36}▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");









































