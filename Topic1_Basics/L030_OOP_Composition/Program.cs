﻿using System.Text;

namespace L030_OOP_Composition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, OOP (DE)Composition!");

            //House();
            //Country();
            Book();
        }

        /*
        Uzduotis 1: Apsirašykite klases, kurios atributų pagalba apibūdintų:
        Žmogų
        Mašiną
        Namą(Savarankiskai)
        Išmanųjį telefoną
        Šalį(Savarankiskai)
        Knygą(Savarankiskai)
        */

        /*
        Uzduotis 2: Parasyti kiekvienai is klasiu bent po 1 kompozicijos atributa 
        (Naujas atributas turetu buti naujai sukurta klase su bent 3 naujais atributais). 
        Kompozicijos atributas yra atributas su kitos klases duomenu tipu kintamuosiuose. 
        Pvz: Zmogus gali tureti augintini
        */

        /*
        
        Namų darbas savaitgaliui.

        Susikurti “Kambarys” klasę ir aprašyti bent 10 objektų esančių jūsų kambaryje arba objektų kurie galėtų egzistuoti kambaryje kaip klases. 
        Visos naujais aprašytos klasės turėtų turėti bent po 5 atributus (Kontraktas/interfeisas) ir turėtų būti priskirtos kaip properties (savybe) “Kambarys” klasei. 
        Bent 2 iš aprašytų klasių turėtų turėti kompoziciją su kitomis klasėmis pvz: ”Kambarys” turi “Spinta”, kuri gali turėti List<Drabuzis>
        */

        public static void Human()
        {
            Human human = new Human();
            human.FirstName = "Vardenis";
            human.LastName = "Pavardenis";
            human.BirthDate = new DateTime(1990-07-14);
            human.Animal.Name = "Marsietis";
            human.Animal.Kind = "Dog";
            human.Animal.Age = 6;

        }

        public static void House()
        {
            House house1 = new House();
            house1.country = "Lietuva";
            house1.city = "Vilnius";
            house1.postCode = "LT20001";
            house1.streetName = "Vilniaus g.";
            house1.houseNumber = "17A";
            house1.buildDate = new DateOnly(2012, 07, 14);
            house1.numberOfFloors = 2;
            house1.isBasemnt = true;

            house1.Garage.isSeparated = true;
            house1.Garage.areaInSqrM = 24.4m;
            house1.Garage.numberOfWindows = 0;

            string strTrue = "True";
            string strFalse = "False";
            string basement = "turi rusi";
            string noBasement = "neturi rusio";

            Console.WriteLine($"Namo adresas - {house1.streetName} {house1.houseNumber}, {house1.postCode}, {house1.city}, {house1.country}.");
            Console.WriteLine($"Namas pastatytas {house1.buildDate} metais, {house1.numberOfFloors} aukstai, {house1.isBasemnt.ToString().Replace(strTrue, basement).Replace(strFalse, noBasement)}.");
        }

        public static void Country()
        {
            Country country1 = new Country();
            country1.Name = "Lietuva";
            country1.Population = 2_795_680;
            country1.AreaInSqrKm = 65_300;
            country1.FriendlyCountry = new FriendlyCountry()
            {
                Name = "Latvija",
                IsNeighbour = true,
                Government = "Demokratija"
            };

        }

        public static void Book()
        {
            var books = new Dictionary<int, Book>();

            var book1 = new Book()
            {
                Name = "Do Androids Dream of Electric Sheep?",
                Author = "Philip K. Dick",
                Genre = "Science fiction",
                PageCount = 210,
                Release = new Release()
            };

            book1.Release.Date = new DateOnly(1982, 1, 1);
            book1.Release.Publisher = "Sundown Publish";
            book1.Release.CoverType = "Hardcover";

            books.Add(1, book1);

            Console.WriteLine(books[1].Release.Date);
            Console.WriteLine(books[1].Release.Publisher);
            Console.WriteLine(books[1].Release.CoverType);

        }

    }
}