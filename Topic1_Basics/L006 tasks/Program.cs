


//========================================================================================
/*
PARAŠYTI PROGRAMĄ KURI
PRAŠO ĮVESTI 2 SKAIČIUS.
JEI ABU LYGŪS,
PROGRAMA TURI IŠVESTI
TRUE , JEI NE FALSE
*/
/*
Console.Write("Iveskite viena skaiciu: ");
int skaicius1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Iveskite kita skaiciu: ");
int skaicius2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{skaicius1} == {skaicius2} -> {skaicius1 == skaicius2}");
*/


//========================================================================================
/*
PARAŠYTI PROGRAMĄ KURI
PRAŠO ĮVESTI 2 SKAIČIUS.
JEI ABU LYGINIAI,
PROGRAMA TURI IŠVESTI
TRUE , JEI NE FALSE
*/
/*
Console.Write("Iveskite viena skaiciu: ");
int skaicius1 = Convert.ToInt32(Console.ReadLine());                // priskiriu ivesta skaiciu prie int kintamojo
Console.Write("Iveskite kita skaiciu: ");
int skaicius2 = Convert.ToInt32(Console.ReadLine());                // ^

int s1liek = skaicius1 % 2;                                         // padalinu skaiciu1 is 2 ir liekana priskiriu naujam kintamajam
int s2liek = skaicius2 % 2;                                         // ^

Console.WriteLine($"ar {skaicius1} yra lyginis -> {s1liek == 0}");  // tikrinu ar liekanos lygios nuliui, taip issiaiskindamas ar skaicius buvo lyginis
Console.WriteLine($"ar {skaicius2} yra lyginis -> {s2liek == 0}");  // ^

Console.WriteLine($"ar abu yra lyginis -> {s1liek == 0 && s1liek == s2liek}");
*/


//========================================================================================
/*
Tikriausiai žinote, kad elektronikoje signalai koduojami dviejų bitų kodu. Ty 0(low) ir 1(high).
išsivaizduokite du ryšio kanalus kurie atsiunčia štai tokią informaciją:
kanalas A __---___---___---___---___
kanalas B ____---___---___---___---_
Apatinis brūkšnys (_) reiškia false, o paprastas (-) true.
Parašykite progamą kuri atvazduoja šių kanalų logines operacijas:
a) A AND B
b) A OR B
c) A XOR B
d) A NAND B
e) A NOR B
f) NOT A
g) NOT A OR B
h) (A OR B) NAND A

atsakymas:
a) ____-_____-_____-_____-___
b) __-----_-----_-----_-----_
c) __--_--_--_--_--_--_--_--_
*/

string a = "__---___---___---___---___";
string b = "____---___---___---___---_";

var a0 = Convert.ToBoolean(Convert.ToString(a[0]).Replace("_", "False").Replace("-", "True"));
var a1 = Convert.ToBoolean(Convert.ToString(a[1]).Replace("_", "False").Replace("-", "True"));
var a2 = Convert.ToBoolean(Convert.ToString(a[2]).Replace("_", "False").Replace("-", "True"));
var a3 = Convert.ToBoolean(Convert.ToString(a[3]).Replace("_", "False").Replace("-", "True"));
var a4 = Convert.ToBoolean(Convert.ToString(a[4]).Replace("_", "False").Replace("-", "True"));
var a5 = Convert.ToBoolean(Convert.ToString(a[5]).Replace("_", "False").Replace("-", "True"));
var a6 = Convert.ToBoolean(Convert.ToString(a[6]).Replace("_", "False").Replace("-", "True"));
var a7 = Convert.ToBoolean(Convert.ToString(a[7]).Replace("_", "False").Replace("-", "True"));
var a8 = Convert.ToBoolean(Convert.ToString(a[8]).Replace("_", "False").Replace("-", "True"));
var a9 = Convert.ToBoolean(Convert.ToString(a[9]).Replace("_", "False").Replace("-", "True"));
var a10 = Convert.ToBoolean(Convert.ToString(a[10]).Replace("_", "False").Replace("-", "True"));
var a11 = Convert.ToBoolean(Convert.ToString(a[11]).Replace("_", "False").Replace("-", "True"));
var a12 = Convert.ToBoolean(Convert.ToString(a[12]).Replace("_", "False").Replace("-", "True"));
var a13 = Convert.ToBoolean(Convert.ToString(a[13]).Replace("_", "False").Replace("-", "True"));
var a14 = Convert.ToBoolean(Convert.ToString(a[14]).Replace("_", "False").Replace("-", "True"));
var a15 = Convert.ToBoolean(Convert.ToString(a[15]).Replace("_", "False").Replace("-", "True"));
var a16 = Convert.ToBoolean(Convert.ToString(a[16]).Replace("_", "False").Replace("-", "True"));
var a17 = Convert.ToBoolean(Convert.ToString(a[17]).Replace("_", "False").Replace("-", "True"));
var a18 = Convert.ToBoolean(Convert.ToString(a[18]).Replace("_", "False").Replace("-", "True"));
var a19 = Convert.ToBoolean(Convert.ToString(a[19]).Replace("_", "False").Replace("-", "True"));
var a20 = Convert.ToBoolean(Convert.ToString(a[20]).Replace("_", "False").Replace("-", "True"));
var a21 = Convert.ToBoolean(Convert.ToString(a[21]).Replace("_", "False").Replace("-", "True"));
var a22 = Convert.ToBoolean(Convert.ToString(a[22]).Replace("_", "False").Replace("-", "True"));
var a23 = Convert.ToBoolean(Convert.ToString(a[23]).Replace("_", "False").Replace("-", "True"));
var a24 = Convert.ToBoolean(Convert.ToString(a[24]).Replace("_", "False").Replace("-", "True"));
var a25 = Convert.ToBoolean(Convert.ToString(a[25]).Replace("_", "False").Replace("-", "True"));

var b0 = Convert.ToBoolean(Convert.ToString(b[0]).Replace("_", "False").Replace("-", "True"));
var b1 = Convert.ToBoolean(Convert.ToString(b[1]).Replace("_", "False").Replace("-", "True"));
var b2 = Convert.ToBoolean(Convert.ToString(b[2]).Replace("_", "False").Replace("-", "True"));
var b3 = Convert.ToBoolean(Convert.ToString(b[3]).Replace("_", "False").Replace("-", "True"));
var b4 = Convert.ToBoolean(Convert.ToString(b[4]).Replace("_", "False").Replace("-", "True"));
var b5 = Convert.ToBoolean(Convert.ToString(b[5]).Replace("_", "False").Replace("-", "True"));
var b6 = Convert.ToBoolean(Convert.ToString(b[6]).Replace("_", "False").Replace("-", "True"));
var b7 = Convert.ToBoolean(Convert.ToString(b[7]).Replace("_", "False").Replace("-", "True"));
var b8 = Convert.ToBoolean(Convert.ToString(b[8]).Replace("_", "False").Replace("-", "True"));
var b9 = Convert.ToBoolean(Convert.ToString(b[9]).Replace("_", "False").Replace("-", "True"));
var b10 = Convert.ToBoolean(Convert.ToString(b[10]).Replace("_", "False").Replace("-", "True"));
var b11 = Convert.ToBoolean(Convert.ToString(b[11]).Replace("_", "False").Replace("-", "True"));
var b12 = Convert.ToBoolean(Convert.ToString(b[12]).Replace("_", "False").Replace("-", "True"));
var b13 = Convert.ToBoolean(Convert.ToString(b[13]).Replace("_", "False").Replace("-", "True"));
var b14 = Convert.ToBoolean(Convert.ToString(b[14]).Replace("_", "False").Replace("-", "True"));
var b15 = Convert.ToBoolean(Convert.ToString(b[15]).Replace("_", "False").Replace("-", "True"));
var b16 = Convert.ToBoolean(Convert.ToString(b[16]).Replace("_", "False").Replace("-", "True"));
var b17 = Convert.ToBoolean(Convert.ToString(b[17]).Replace("_", "False").Replace("-", "True"));
var b18 = Convert.ToBoolean(Convert.ToString(b[18]).Replace("_", "False").Replace("-", "True"));
var b19 = Convert.ToBoolean(Convert.ToString(b[19]).Replace("_", "False").Replace("-", "True"));
var b20 = Convert.ToBoolean(Convert.ToString(b[20]).Replace("_", "False").Replace("-", "True"));
var b21 = Convert.ToBoolean(Convert.ToString(b[21]).Replace("_", "False").Replace("-", "True"));
var b22 = Convert.ToBoolean(Convert.ToString(b[22]).Replace("_", "False").Replace("-", "True"));
var b23 = Convert.ToBoolean(Convert.ToString(b[23]).Replace("_", "False").Replace("-", "True"));
var b24 = Convert.ToBoolean(Convert.ToString(b[24]).Replace("_", "False").Replace("-", "True"));
var b25 = Convert.ToBoolean(Convert.ToString(b[25]).Replace("_", "False").Replace("-", "True"));

Console.Write("a) ");
Console.Write((a0 && b0).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a1 && b1).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a2 && b2).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a3 && b3).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a4 && b4).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a5 && b5).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a6 && b6).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a7 && b7).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a8 && b8).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a9 && b9).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a10 && b10).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a11 && b11).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a12 && b12).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a13 && b13).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a14 && b14).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a15 && b15).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a16 && b16).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a17 && b17).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a18 && b18).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a19 && b19).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a20 && b20).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a21 && b21).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a22 && b22).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a23 && b23).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a24 && b24).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a25 && b25).ToString().Replace("False", "_").Replace("True", "-"));

Console.WriteLine();
Console.Write("b) ");
Console.Write((a0 || b0).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a1 || b1).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a2 || b2).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a3 || b3).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a4 || b4).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a5 || b5).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a6 || b6).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a7 || b7).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a8 || b8).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a9 || b9).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a10 || b10).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a11 || b11).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a12 || b12).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a13 || b13).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a14 || b14).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a15 || b15).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a16 || b16).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a17 || b17).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a18 || b18).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a19 || b19).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a20 || b20).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a21 || b21).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a22 || b22).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a23 || b23).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a24 || b24).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a25 || b25).ToString().Replace("False", "_").Replace("True", "-"));

Console.WriteLine();
Console.Write("c) ");
Console.Write((a0 ^ b0).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a1 ^ b1).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a2 ^ b2).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a3 ^ b3).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a4 ^ b4).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a5 ^ b5).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a6 ^ b6).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a7 ^ b7).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a8 ^ b8).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a9 ^ b9).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a10 ^ b10).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a11 ^ b11).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a12 ^ b12).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a13 ^ b13).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a14 ^ b14).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a15 ^ b15).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a16 ^ b16).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a17 ^ b17).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a18 ^ b18).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a19 ^ b19).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a20 ^ b20).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a21 ^ b21).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a22 ^ b22).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a23 ^ b23).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a24 ^ b24).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((a25 ^ b25).ToString().Replace("False", "_").Replace("True", "-"));

Console.WriteLine();
Console.Write("d) ");
Console.Write((!(a0 && b0)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a1 && b1)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a2 && b2)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a3 && b3)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a4 && b4)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a5 && b5)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a6 && b6)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a7 && b7)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a8 && b8)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a9 && b9)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a10 && b10)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a11 && b11)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a12 && b12)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a13 && b13)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a14 && b14)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a15 && b15)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a16 && b16)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a17 && b17)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a18 && b18)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a19 && b19)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a20 && b20)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a21 && b21)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a22 && b22)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a23 && b23)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a24 && b24)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a25 && b25)).ToString().Replace("False", "_").Replace("True", "-"));

Console.WriteLine();
Console.Write("e) ");
Console.Write((!(a0 || b0)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a1 || b1)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a2 || b2)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a3 || b3)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a4 || b4)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a5 || b5)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a6 || b6)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a7 || b7)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a8 || b8)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a9 || b9)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a10 || b10)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a11 || b11)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a12 || b12)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a13 || b13)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a14 || b14)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a15 || b15)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a16 || b16)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a17 || b17)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a18 || b18)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a19 || b19)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a20 || b20)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a21 || b21)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a22 || b22)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a23 || b23)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a24 || b24)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!(a25 || b25)).ToString().Replace("False", "_").Replace("True", "-"));

Console.WriteLine();
Console.Write("f) ");
Console.Write((!a0).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a1).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a2).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a3).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a4).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a5).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a6).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a7).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a8).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a9).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a10).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a11).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a12).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a13).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a14).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a15).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a16).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a17).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a18).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a19).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a20).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a21).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a22).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a23).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a24).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a25).ToString().Replace("False", "_").Replace("True", "-"));

Console.WriteLine();
Console.Write("g) ");
Console.Write((!a0 || b0).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a1 || b1).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a2 || b2).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a3 || b3).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a4 || b4).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a5 || b5).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a6 || b6).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a7 || b7).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a8 || b8).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a9 || b9).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a10 || b10).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a11 || b11).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a12 || b12).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a13 || b13).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a14 || b14).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a15 || b15).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a16 || b16).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a17 || b17).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a18 || b18).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a19 || b19).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a20 || b20).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a21 || b21).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a22 || b22).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a23 || b23).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a24 || b24).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!a25 || b25).ToString().Replace("False", "_").Replace("True", "-"));

Console.WriteLine();
Console.Write("h) ");
Console.Write((!((a0 || b0) && a0)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a1 || b1) && a1)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a2 || b2) && a2)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a3 || b3) && a3)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a4 || b4) && a4)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a5 || b5) && a5)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a6 || b6) && a6)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a7 || b7) && a7)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a8 || b8) && a8)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a9 || b9) && a9)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a10 || b10) && a10)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a11 || b11) && a11)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a12 || b12) && a12)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a13 || b13) && a13)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a14 || b14) && a14)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a15 || b15) && a15)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a16 || b16) && a16)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a17 || b17) && a17)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a18 || b18) && a18)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a19 || b19) && a19)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a20 || b20) && a20)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a21 || b21) && a21)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a22 || b22) && a22)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a23 || b23) && a23)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a24 || b24) && a24)).ToString().Replace("False", "_").Replace("True", "-"));
Console.Write((!((a25 || b25) && a25)).ToString().Replace("False", "_").Replace("True", "-"));

Console.WriteLine();
Console.WriteLine(354 - 68);


//========================================================================================
/*
Prašykite programą kuri pritaikius loginę funkciją grąžina tokius rezultatus
A B F(A,B)
0 0 0
0 1 1
1 0 1
1 1 1

A B F(A,B)
0 0 1
0 1 1
1 0 0
1 1 1

A B F(A,B)
0 0 1
0 1 0
1 0 1
1 1 0

A B C F(A,B,C)                                                                  <<<<<<<<<<<<<<<<<<<<<< 
0 0 0 1
0 0 1 0
0 1 0 0
0 1 1 0
1 0 0 1
1 0 1 0
1 1 0 0
1 1 1 1
*/

// ats:
// 1. A||B
// 2. !A||B
// 3. !((a||b) && b)
// 4. 
/*

Console.WriteLine("TESTING");
Console.WriteLine($"{false ^ false ^ false}");
Console.WriteLine($"{false ^ true ^ true}");
Console.WriteLine($"{true ^ false ^ false}");
Console.WriteLine($"{true ^ true ^ true}"); 
*/

