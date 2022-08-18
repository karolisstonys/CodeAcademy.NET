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

        public List<Animal> FetchAnimals()
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


    }
}
