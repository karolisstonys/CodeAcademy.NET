using L038_Practice.Models;

namespace L038_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Practice!");










        }

        /* Task1  
            1 - Sukurkite klase Hobby su properčiais
                - Id
                - Text
                - TextLt
            2- Sukurkite konstruktorių be parametrų (pasiekiama visur)
            3- Sukurkite konstruktorių su id, text, textLt parametrais (pasiekiama visur)
            4- Skirtingais būdais inicializuokite  klases. Įrašykite po 3 hobius.
            5- Hobby klasėje sukurkite metodą kuris iškoduos HobbyInitialData.DataSeedCsv vieną įrašą (string)
                ir užpildys properčius duomenimis. unit-test */

        public static void Task1()
        {

            // DO NOT USE =)
            var hobby1 = new Hobby();
            hobby1.Id = 1;
            hobby1.Text = "Something";
            hobby1.TextLt = "Kas nors";
            
            // Object Initializer
            var hobby2 = new Hobby()     
            {
                Id = 2,
                Text = "Text",
                TextLt = "Tekstas"
            };

            // Constructor with parameters
            var hobby3 = new Hobby(3, "Hobby", "Hobis");


        }
    }
}