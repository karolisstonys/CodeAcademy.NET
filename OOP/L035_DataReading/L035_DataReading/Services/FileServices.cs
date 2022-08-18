using L035_DataReading.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L035_DataReading.Services
{
    public class FileServices
    {
        readonly string _filePath;

        public FileServices (string filePath)
        {
            _filePath = filePath;
        }

        public string ReadTextFromFile()
        {
            return File.ReadAllText(_filePath);
        }

        public string[] ReadFileLines()
        {
            return File.ReadAllLines(_filePath);
        }

        public List<Animal> FetchAnimalTxtRecords()
        {
            int animalColCount = 2;
            List<Animal> animals = new List<Animal>();

            using StreamReader sr = new StreamReader(_filePath);

            string animalLine;

            while ((animalLine = sr.ReadLine()) != null)
            {
                string[] animalData = animalLine.Split(',');

                if (animalData.Length != animalColCount) break;

                Animal newAnimal = new Animal(animalData);
                animals.Add(newAnimal);
            }

            return animals;
        }

        public List<User> FetchBasicUserCsvRecords()
        {
            int userColumnCount = 2;
            List<User> users = new List<User>();

            using StreamReader sr = new StreamReader(_filePath);

            string userLine;

            while ((userLine = sr.ReadLine()) != null)
            {
                string[] userData = userLine.Split(',');

                if (userData.Length != userColumnCount) break;

                User newUser = new User(userData);
                users.Add(newUser);
            }

            return users;
        }

        public void ReadStreamSymbolsFromFile()
        {
            FileStream fileStream = File.OpenRead(_filePath);   // LEGACY failu atidarinejimas !

            using StreamReader sr = new StreamReader(_filePath);

            char nextChar = (char)sr.Read();

            char[] bufferToPutStuffIn = new char[2];
            sr.Read(bufferToPutStuffIn, 0, 2);

            string whatWasRed = new string(bufferToPutStuffIn);

            Console.WriteLine($"nextChar: {nextChar}");
            Console.WriteLine($"whatWasRed: {whatWasRed}");

            //sr.Close(); // Nebereikia nes naudojame 'using StreamReader'
        }

    }
}
