namespace L034_Practice
{
    internal class Program
    {
        static void Main(string[] args)
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



    }







}