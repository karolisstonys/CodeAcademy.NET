using L042_Practice.Interfaces;
using L042_Practice.Services;

namespace L042_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = new DirectoryInfo(Environment.CurrentDirectory)+ "\\InitialData\\BookDataSeed.html";
            string dataSeed = File.ReadAllText(path);

            var test = new BookService();
            var a = test.Decode(dataSeed);
        }

        /*  Sukurkite abstract klasę Book
            Sukurkite klasę EBook pavaldėtą iš Book klasės.
            Sukurkite klasę AudioBook pavaldėtą iš Book klasės.
            Sukurkite klasę PaperbackBook pavaldėtą iš Book klasės.
            Sukurkite klasę HardcoverBook pavaldėtą iš Book klasės.
            - knygų duomenys pateikiami ir struktūra kaip - BookInitialData.DataSeedHtml */


    }
}