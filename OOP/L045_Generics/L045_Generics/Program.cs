
using L045_Generics.Interfaces;
using L045_Generics.Models;

namespace L045_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Generics!");
            FirstExample();
        }

        #region PIRMI_PAVYZDZIAI
        public static void FirstExample()
        {
            // Pirmas generic pavyzdys
            List<int> genericNumberList = new List<int>();
            List<string> genericStringList = new List<string>();
            List<DateTime> genericDateTimeList = new List<DateTime>();
            IList<decimal> genericDecimalList = new List<decimal>();
            IList<ITool> toolList = new List<ITool>();

            Fork fork1 = new Fork();
            Keyboard keyboard1 = new Keyboard();
            toolList.Add(fork1);
            toolList.Add(keyboard1);

            foreach (ITool tool in toolList)
            {
                tool.PrintName();
            }

            // Antras generic pavyzdys
            Dictionary<int, string> userDictionary = new Dictionary<int, string>();
            Dictionary<Guid, double> hashDictionary = new Dictionary<Guid, double>();
            Dictionary<Guid, Keyboard> keyboardDictionary = new Dictionary<Guid, Keyboard>();

            // Musus paciu sukurta GENERIC klase
            NodeList<int> numberNodeList = new NodeList<int>();
            numberNodeList.Add(10);
            numberNodeList.Add(10);
            numberNodeList.Add(9);
            numberNodeList.Add(10);
            numberNodeList.Add(8);
            numberNodeList.ProcessAllNodes();

            NodeList<string> stringNodeList = new NodeList<string>();
            stringNodeList.Add("aaaaa");
            stringNodeList.Add("bbbbb");
            stringNodeList.Add("ccccc");
            stringNodeList.Add("ddddd");
            stringNodeList.Add("eeeee");
            numberNodeList.ProcessAllNodes();

            NodeList<ITool> toolNodeList = new NodeList<ITool>();
            toolNodeList.Add(fork1);
            toolNodeList.Add(keyboard1);
            toolNodeList.ProcessAllNodes();

        }

        #endregion

        /* Uzduotis 1
        Sukurkite generic klase <Cordinate>, kuri gali buti bet kokio tipo (int, string, double, datetime) kordinate x ir y asyse. 
        Jusu klase turetu tureti generic konstruktoriu, kuris gali priimti, bet kokio tipo x ir y kordinates. 
        X ir y pozicijas galima keisti ir kituose projektuose kreipiantis i objekta. 
        Paveldekite is <ICordinate> interface, kuris savyje turi: 
            string GetCordinate()
            grazina x ir y kordinates viename stringe
            void ResetCordinate()
            grazina default reiksmes
            metodus. 
        Irodykite veikima sukurdami 3 atskirus objektus. 
        Pirmas objektas su string, antras su int, trecias su dateTime. 
        Testai turetu patikrinti abu metodus ir bent 3 skirtingais duomenu tipais inicializuotas reiksmes 
        (Siem testam pasitelkite GetCordinate metoda) */

    }
}