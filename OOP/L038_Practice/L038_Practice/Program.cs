﻿using L038_Practice.Models;

namespace L038_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Practice!");





            Task2();




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

        /* Task2  
        sukurite klasę UniversityPerson paveldėtą iš Person klasės. Pridėkite properčius.
        - Profession (Profession)
        - Hobbies (List of Hobby)
        
        1- Padarykite metodą kuris atsitiktinai asmeniui pariks nuo 0 iki 4 hobių iš HobbyInitialData.DataSeedCsv. 
            Užtikrinkite,kad tas pat hobis nepasikartotu 2 kartus
        
        2- Naudodami method overload padarykite metodus kurie atsitiktinai asmeniui pariks 1 profesiją iš  
            ProfessionInitialData.DataSeed arba 
            ProfessionInitialData.DataSeedCsvComma arba
            ProfessionInitialData.DataSeedCsvSemicolon.
        
        3- Padarykite metodą GetCsv() kuris grąžina string t.y.
            Iš užpildytos klasės UniversityPerson duomenų sukurs CSV formato DataSeed. Taip, kad galėtume naudoti jį vėliau. (unit-test) */

        public static void Task2()
        {
            var univercityPerson = new UniversityPerson()

            {
                Id = 1,
                FirstName = "aaa",
                LastName = "bbb",
                Gender = EGender.MALE
            };
            univercityPerson.SetUpto4Hobies();


            foreach (var item in univercityPerson.Hobbies)
            {
                Console.WriteLine(univercityPerson.Hobbies);
            }

        }












    }
}