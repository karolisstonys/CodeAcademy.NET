
// Loginiai operatoriai - && (AND) - || (OR) - ! (NOT) - ^ (XOR)

// NEIGIMAS - ! - NOT
bool tiesa = true;
bool melas = !tiesa;
Console.WriteLine($"tiesa = {tiesa}, melas = {melas}, !melas = {!melas}");
Console.WriteLine();

// KONJUNKCIJA - && - AND - Ampersand Ampersand
Console.WriteLine($"tiesa AND tiesa - {tiesa && tiesa}");
Console.WriteLine($"tiesa AND melas - {tiesa && melas}");
Console.WriteLine($"melas AND tiesa - {melas && tiesa}");
Console.WriteLine($"melas AND melas - {melas && melas}");
Console.WriteLine();

// Disjunkcija - || - OR
Console.WriteLine($"tiesa OR tiesa - {tiesa || tiesa}");
Console.WriteLine($"tiesa OR melas - {tiesa || melas}");
Console.WriteLine($"melas OR tiesa - {melas || tiesa}");
Console.WriteLine($"melas OR melas - {melas || melas}");
Console.WriteLine();

// ^ - XOR - exclusive or
Console.WriteLine($"tiesa XOR tiesa - {tiesa ^ tiesa}");
Console.WriteLine($"tiesa XOR melas - {tiesa ^ melas}");
Console.WriteLine($"melas XOR tiesa - {melas ^ tiesa}");
Console.WriteLine($"melas XOR melas - {melas ^ melas}");
Console.WriteLine();

// NAND - ! AND
Console.WriteLine($"tiesa NAND tiesa - {!(tiesa && tiesa)}");
Console.WriteLine($"tiesa NAND melas - {!tiesa && !melas}");
Console.WriteLine($"melas NAND tiesa - {!(melas && tiesa)}");
Console.WriteLine($"melas NAND melas - {!(melas && melas)}");
Console.WriteLine();

// NOR - ! OR
Console.WriteLine($"tiesa NOR tiesa - {!(tiesa || tiesa)}");
Console.WriteLine($"tiesa NOR melas - {!(tiesa || melas)}");
Console.WriteLine($"melas NOR tiesa - {!(melas || tiesa)}");
Console.WriteLine($"melas NOR melas - {!(melas || melas)}");
Console.WriteLine();

// NXOR - ! XOR
Console.WriteLine($"tiesa NXOR tiesa - {!(tiesa ^ tiesa)}");
Console.WriteLine($"tiesa NXOR melas - {!(tiesa ^ melas)}");
Console.WriteLine($"melas NXOR tiesa - {!(melas ^ tiesa)}");
Console.WriteLine($"melas NXOR melas - {!(melas ^ melas)}");
Console.WriteLine();

//===========================================================================================================================

Console.WriteLine($"melas OR melas OR tiesa AND tiesa - {melas || melas || tiesa && tiesa}");
Console.WriteLine($"melas OR tiesa OR melas AND tiesa - {melas || tiesa || melas && tiesa}");

int a = 5;
int b = 5;
int c = 6;

bool s = a >= b && a > c;
Console.WriteLine(s);








