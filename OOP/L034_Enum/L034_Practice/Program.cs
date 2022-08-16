using L034_Practice.Domain;

namespace L034_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task2();

            Task3();

        }


        /*
        1. Sukurkite enum EGenderType su reikšmėmis 0 - MALE, 1 - FEMALE
        */

        /*
        2. Sukurkite klasę Person su properčiais:
            - Id(int),
            - FirstName(string),
            - LastName(string),
            - FullName(readonly string - generuojamas iš FirstName ir LastName)
            - Gender(int - užpildomas tik inicializuojant klasę reikšme arba per metodą iš enumo EGenderType )
            - BirthDate (DateTime - gali būtu null)
            - Height (Decimal)
            - Weight (Decimal)
            - Age (readonly int - gali būti null. Generuojamas iš gimimo datos (BirthDate). Generavimui naudoti metodą)
            - NameChanges (string - įrašomas tik iš vidaus. Pildomas pakeitus FirstName arba LastName.
            Saugomi visi pakeitimai csv formatu "senas,naujas" )
        */
        public static void Task2()
        {
            Person person1 = new Person("Petras", "Peeeetrauskas", EGender.MALE, 1.80m, 80m)
            {
                BirthDate = new DateTime(1990, 01, 15),
            };

            person1.LastName = "Petrauskas";
            person1.LastName = "nesakysiu";

            Console.WriteLine($"Pilnas vardas - {person1.FullName}");
            Console.WriteLine($"Vardo keitimo istorija: {person1.nameChanges}");
            Console.WriteLine($"Amzius - {person1.Age}");
        }


        /*
        3. Sukurkite klasę Society
            1- Sukurkite propertį People (List of persons)
            2- sukurkite metodą FillPeople kuris užpildys sąrašą iš klasės PersonInitialData.
            3- Sukurkite propertį OldPeople. Grąžinkite visus asmenis kurie gimė prieš 2001m. (unit-test)
            4- Sukurkite properčius Men ir Women.
            5- Sukurkite metodus FillMen ir FillWomen, kurie iš PersonInitialData surašys vyrus ir moteris (unit-test)
            6- sukurkite metodą SortByAge(), kuris Men ir Women sąrašus esančius asmenis surikiuotu pagal amžių nuo jauniausio iki vyriausio.
            7- Padarykite metodą kuris People, Men ir Women properčiuose esančius asmenis  rikiuos nuo A iki Z arba nuo Z iki A.
            Pagal Vardą arba Pavardę
                tokiu principu: SortByFirstName().Asc()
                                SortByLastName().Asc()
                                SortByLastName().Desc()
            <hint> return this
        */
        private static void Task3()
        {
            var test = new Society();
            test.FillPeople();
            test.FillMen();
            test.FillWomen();

        }




    }







}