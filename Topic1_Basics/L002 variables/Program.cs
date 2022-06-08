namespace L002_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("KOMENTARU TESTAS");

            // komentaras

            /*
            komentarai
            komentarai
            komentarai
            komentarai
            komentarai
            */

            //Console.WriteLine("");   // komentaras

            //var test = /* cia irgi komentaras */ "testas";

            //Console.WriteLine("Kodel reikia rasyti komentarus?");
            // 1. po kurio laiko greiciausiai neprisiminsite ka jus pats esate parases.
            // 2. didele tikimybe kad po kurio laiko net ne jus ziuresite i ta koda


            //Console.WriteLine("Kaip rasyti gerus komentarus?");
            // 1. Rasyti komentarus kodo gabalui kuris yra funkciskai isbaigtas.
            // 2. Rasyti komentarus kurie prideda kodui prasmes, o ne tiesiog pasako ka kodas daro.

            // -----------------------------------------------

            // BLOGAS PVZ
            // Console.WriteLine("Hello World!"); isveda i ekrana "Hello World!"
            //Console.WriteLine("Hello World!");
            /*
             JUK IR TAIP AISKU KA DARO KODAS.
             */

            //GERAS PVZ
            // Tai mano pirmoji veikianti programa.
            //Console.WriteLine("Hello World!");

            // -----------------------------------------------

            // TASKS:

            //Console.WriteLine("Karolis");                                   // i konsole isvedamas mano vardas
            //Console.Write("Iveskite savo varda: ");                         // konsoleje parasoma ka reikia mums padaryti
            //Console.WriteLine("Jusu vardas: {0}", Console.ReadLine());      // atklartojamas ivestas i konsole "vardas" su papildomu tekstu priekyje

            //Console.WriteLine("Iveskite viena raide ir viena skaiciu: ");
            // ReadKey nuskaitimas vieno po kito dvieju prasomu ivesti simboliu, po to jie sudedami
            //Console.WriteLine("Suminis ACSII rezultatas yra - {0}", (int)Console.ReadKey().KeyChar + (int)Console.ReadKey().KeyChar); 

            // -----------------------------------------------

            // KONKATINACIJA
            //Console.WriteLine("(1) Pirkti\n(2) Parduoti\n(3)Likutis\n");
            //Console.WriteLine("Jusu pasirinkimas: " + Console.ReadKey().KeyChar);

            // KOMPOZICIJA
            //Console.WriteLine("(1) Pirkti\n(2) Parduoti\n(3)Likutis\n");
            //Console.WriteLine("Jusu pasirinkimas: {0}", Console.ReadKey().KeyChar);

            // INTERPOLIACIJA
            //Console.WriteLine("(1) Pirkti\n(2) Parduoti\n(3)Likutis\n");
            //Console.WriteLine($"Jusu pasirinkimas: {Console.ReadKey().KeyChar}");

            // -----------------------------------------------

            //Console.WriteLine("L\nA\nB\nA\nS");
            //Console.WriteLine("L\tA\tB\tA\tS");

            //Console.WriteLine("\"LABAS\"");
            //Console.WriteLine(Convert.ToChar(0x22) + "LABAS" + Convert.ToChar(0x22));
            //Console.WriteLine("{0}LABAS{0}", Convert.ToChar(0x22));
            //Console.WriteLine($"{Convert.ToChar(0x22)}LABAS{Convert.ToChar(0x22)}");

            //Console.Write("Irasykite savo varda: ");
            //Console.WriteLine("Jusu vardo antra raide yra :" + Console.ReadLine()[1]);

            //Console.Write("Irasykite savo varda: ");
            //Console.WriteLine("Jusu varde yra " + Console.ReadLine().Count() + " raides");

            //Console.Write("Irasykite savo varda: ");
            //Console.WriteLine("Jusu varde yra " + Console.ReadLine().Length + " raides");

            //Console.WriteLine("Write your name, click ENTER.");
            //Console.WriteLine("Write any number, click ENTER.");
            //Console.WriteLine("|\t\t{0}\t|\t\t{1}\t|", Console.ReadLine(), Console.ReadLine());

            //Console.WriteLine("Vardas:\n\n\n{0}", Console.ReadLine());

            /*
            Console.WriteLine(@"
                 *****************
                *                 *   
                *    O      O     *
                *      (oo)       *
                *                 *
                *   \_________/   * 
                 *               * 
                   *************".Replace("*", "\""));



            Console.WriteLine(@"
                 {0}{0}{0}{0}{0}{0}{0}{0}{0}{0}
                {0}          {0}   
                {0}  {0}    {0}  {0}
                {0}    {0}     {0}
                {0}          {0}
                {0}  {0}    {0}  {0} 
                 {0}  {0}{0}{0}{0}  {0} 
                  {0}{0}{0}{0}{0}{0}{0}{0}", Console.ReadKey().KeyChar);
            */            

            // ================================================================================================
            // =====================================!=KINTAMIEJI=!=============================================
            // ================================================================================================

            
            string myString = "some random string 1 2 3";
            string emptyString = "";
            string nullString = null;
            string whitespaceString = "   ";

            // i STRING kintamaji gali sutilpti apie 1,000,000,000 simboliu

            string konkatinacija = myString + whitespaceString + myString;
            Console.WriteLine(konkatinacija);

            string kompozicija = string.Format("{0}{1}{0}", myString, whitespaceString);
            Console.WriteLine(kompozicija);


            string Interpoliacija = $"{myString}{whitespaceString}{myString}";
            Console.WriteLine(Interpoliacija);
            

            // ================================================================================================

            // kintamaji galima pradeti vadinti mazaja raide, didziaja raide arba _ (underscore):
            string strng = "";
            string Strng = "";
            string _strng = "";


        }
    }
}