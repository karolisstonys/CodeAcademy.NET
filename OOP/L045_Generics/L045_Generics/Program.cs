using L045_Generics.Interfaces;
using L045_Generics.Models;

namespace L045_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Generics!");
            //BasicGenericExamples();

            Task2();
        }


        #region PIRMI_PAVYZDZIAI
        public static void BasicGenericExamples()
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

            ICustomList<int> number2List = new NodeList<int>();


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

        public class Cordinate<T>
        {

        }

        #region BASIC_PAVYZDZIAI

        public static void GenericConstraintsAndFilters()
        {
            // struct   →   filtras skirtas atskirti ar perduodama yra value dalis
            // class    →   filtras skirtas atskirti ar perduoma dalis yra refference tipo
            // new()    →   filtras skirtas atskirti ar perduodama klase su tusciu konstruktoriu
            // <BETKOKIA_KLASE>     →   filtas skirtas atskirti ar perduodama nurodyta klase
            // <BETKOKS_INTERFACE>  →   filtras skirtas ar perduodama nurodyta interfaceklase
            // U    →   filtras skirtas patikrinti paveldimuma

            NodeListFilterStruct<int> structNodeList1 = new NodeListFilterStruct<int>();
            NodeListFilterStruct<DateTime> structNodeList2 = new NodeListFilterStruct<DateTime>();
            // NodeListFilterStruct veikia tik su value tipais
            //NodeListFilterStruct<ITool> structNodeList3 = new NodeListFilterStruct<ITool>();

            NodeListFilterClass<ITool> classNodeList1 = new NodeListFilterClass<ITool>();
            NodeListFilterClass<string> classNodeList2 = new NodeListFilterClass<string>();
            // NodeListFilterClass veikia tik su refference tipais
            // NodeListFilterClass<int> classNodeList3 = new NodeListFilterClass<int>();

            NodeListFilterClassNew<Fork> classNewNoteList = new NodeListFilterClassNew<Fork>();
            // NodeListFilterClassNew priima tik klases tipo duomenu tipus, kurie turi tuscia konstruktoriu
            // NodeListFilterClassNew<ITool> classNewNoteList = new NodeListFilterClassNew<ITool>();

            NodeListFilterSpecifiedClass<Tool> specifiedClassNodeList1 = new NodeListFilterSpecifiedClass<Tool>();
            NodeListFilterSpecifiedClass<Fork> specifiedClassNodeList2 = new NodeListFilterSpecifiedClass<Fork>();
            // NodeListFilterSpecifiedClass priima tik klase, kuri buvo nurodyta, arba klases kurios paveldeja is pateiktos klases
            // NodeListFilterSpecifiedClass<ITool> specifiedClassNodeList3 = new NodeListFilterSpecifiedClass<ITool>();

            NodeListFilterSpecifiedInterface<ITool> toolSpecifiedInterfaceNodeList1 = new NodeListFilterSpecifiedInterface<ITool>();
            NodeListFilterSpecifiedInterface<Fork> toolSpecifiedInterfaceNodeList2 = new NodeListFilterSpecifiedInterface<Fork>();
            // NodeListFilterSpecifiedInterface priima tik intercafe ar klases, kurios paveldeja nurodyta interface
            // NodeListFilterSpecifiedInterface<int> toolSpecifiedInterfaceNodeList3 = new NodeListFilterSpecifiedInterface<int>();




            // -------------------------------------------------------------------------------------------------------




            Fork fork3 = new Fork();
            GenericMethodBaseClass methodBaseClass = new GenericMethodBaseClass();
            methodBaseClass.Print("Hello");
            methodBaseClass.Print(fork3);



        }



        #endregion

        /* Uzduotis 2
        + Pries uzduotis susikurti 3 klases: PrivateClient, Administrator, BusinessClient. 
        + Visos jos paveldeja is interface IUser (int Id get set, string Name get set, )
        + Sukurti generic <EntityRepository> klase, kuri priimtu klases su tusciu konstruktoriumi duomenu tipa ir turetu metodus: 
        +     Add, 
        +     Remove, 
        +     Print(), 
        +     Fetch(). 
        + Repository savyje turi tureti generic sarasa, kuris priimtu sias 3 klases: 
        +     PrivateClient, 
        +     Administrator, 
        +     BusinessClient. 
        Tam, kad igyvendintumete salyga naudokite interface kaip duomenu tipa savo repository objektui. 
        Veikima irodykite testu pagalba (Isskyrus print) ir Main() metode idekite naujai sukurtus 3 objektus (Kiekvienai klasei po viena) */


        public static void Task2()
        {
            IUser user1 = new PrivateClient()
            {
                Id = 1,
                Name = "Private"
            };

            IUser user2 = new Administrator()
            {
                Id = 2,
                Name = "Admin"
            };

            IUser user3 = new BusinessClient()
            {
                Id = 3,
                Name = "Business"
            };

            EntityRepository<IUser> entity = new EntityRepository<IUser>();










        }



    }
}