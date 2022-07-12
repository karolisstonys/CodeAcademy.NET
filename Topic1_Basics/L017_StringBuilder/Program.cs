using System.Text;

namespace L017_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //String builder sukurimas
            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder("Labas pasauli!");
            StringBuilder sb2 = new StringBuilder(1234567890);


            //Isvedimas i ekrana
            Console.WriteLine(sb.ToString());


            //Teksto pridejimas per StringBuilder
            sb.Append("Labas");
            sb.AppendLine("Pasauli");
            sb.AppendLine("labas C#");
            Console.WriteLine(sb.ToString());


            //Teksto iterpimas per StringBuilder
            sb.Insert(5, " ");
            Console.WriteLine(sb.ToString());


            //Teksto pasalinimas per StringBuilder
            sb.Remove(7, 6);
            Console.WriteLine(sb.ToString());


            //Teksto pakeitimas per StringBuilder
            sb.Replace("Labas", "Hi");
            Console.WriteLine(sb.ToString());


        }
    }
}