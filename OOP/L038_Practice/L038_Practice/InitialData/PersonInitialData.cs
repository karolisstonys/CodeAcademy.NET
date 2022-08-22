﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L038_Practice.Domain
{
    internal class PersonInitialData
    {
        public static readonly Person[] DataSeed =
       {
               new Person { Id = 1, FirstName = "Laurynas ", LastName = "Laurynaitis",  Gender = EGender.MALE, Height = 180, Weight = 80.2M, BirthDate = DateTime.Parse("1976-01-05")},
               new Person { Id = 3, FirstName = "Adomas",    LastName = "Adomaitis",    Gender = EGender.MALE, Height = 169, Weight = 105.2M, BirthDate = DateTime.Parse("2000-03-01")},
               new Person { Id = 4, FirstName = "Linas",     LastName = "Linasis",      Gender = EGender.MALE, Height = 191, Weight = 95.5M, BirthDate = DateTime.Parse("2002-12-05")},
               new Person { Id = 5, FirstName = "Matas ",    LastName = "Matalas",      Gender = EGender.MALE, Height = 179, Weight = 99.2M, BirthDate = DateTime.Parse("2001-05-03")},
               new Person { Id = 6, FirstName = "Andrius",   LastName = "Andriulaitis", Gender = EGender.MALE, Height = 172, Weight = 78.0M, BirthDate = DateTime.Parse("2000-03-03") },
               new Person { Id = 7, FirstName = "Irma",      LastName = "Irmiene",      Gender = EGender.FEMALE, Height = 170, Weight = 65.7M, BirthDate = DateTime.Parse("1999-01-24")},
               new Person { Id = 8, FirstName = "Karolina",  LastName = "Karolinaite",  Gender = EGender.FEMALE, Height = 168, Weight = 55.2M, BirthDate = DateTime.Parse("2000-01-25")},
               new Person { Id = 9, FirstName = "Ieva",      LastName = "Ievaite",      Gender = EGender.FEMALE, Height = 178, Weight = 77.9M, BirthDate = DateTime.Parse("2000-02-09")},
               new Person { Id = 10, FirstName = "Vilte",    LastName = "Vilte",        Gender = EGender.FEMALE, Height = 158, Weight = 52.7M, BirthDate = DateTime.Parse("2000-02-09")},
               new Person { Id = 11, FirstName = "Julija",   LastName = "Julijiene",    Gender = EGender.FEMALE, Height = 161, Weight = 95.2M, BirthDate = DateTime.Parse("1998-02-07")},
               new Person { Id = 12, FirstName = "Rasa",     LastName = "Rasiene",      Gender = EGender.FEMALE, Height = 167, Weight = 50.2M, BirthDate = DateTime.Parse("2000-12-05")},
               new Person { Id = 13, FirstName = "Jurga",    LastName = "Jurgaite",     Gender = EGender.FEMALE, Height = 160, Weight = 50.8M, BirthDate = DateTime.Parse("2000-02-14")},
               new Person { Id = 14, FirstName = "Alicija",  LastName = "Alice",        Gender = EGender.FEMALE, Height = 176, Weight = 72.1M, BirthDate = DateTime.Parse("2000-04-15")},
               new Person { Id = 15, FirstName = "Tadas",    LastName = "Tadauskas",    Gender = EGender.MALE, Height = 196, Weight = 105.0M, BirthDate = DateTime.Parse("2000-06-25")},
               new Person { Id = 16, FirstName = "Mykolas",  LastName = "Mykolaitis",   Gender = EGender.MALE, Height = 180, Weight = 89.9M, BirthDate = DateTime.Parse("2000-07-15")},
               new Person { Id = 17, FirstName = "Arturas",  LastName = "Arturauskas",  Gender = EGender.MALE, Height = 176, Weight = 61.8M, BirthDate = DateTime.Parse("2000-08-15")},
               new Person { Id = 18, FirstName = "Dominykas",LastName = "Domikas",      Gender = EGender.MALE, Height = 188, Weight = 120.2M, BirthDate = DateTime.Parse("2000-02-15")},
               new Person { Id = 19, FirstName = "Erikas",   LastName = "Erikauskas",   Gender = EGender.MALE, Height = 166, Weight = 120.2M, BirthDate = DateTime.Parse("2000-03-11")},
               new Person { Id = 20, FirstName = "Simonas",  LastName = "Simonauskas",  Gender = EGender.MALE, Height = 178, Weight = 67.2M, BirthDate = DateTime.Parse("2000-02-12")},
        };
    }
}
