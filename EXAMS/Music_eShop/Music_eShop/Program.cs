using Music_eShop.Domain.Services;
using Music_eShop.Infrastructure;
using Music_eShop.Infrastructure.Database;
using Music_eShop.Infrastructure.Interfaces;
using System.Text;

namespace Music_eShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1200);
            Console.InputEncoding = Encoding.GetEncoding(1200);

            IShopConsole eShop = new ShopConsole();
            eShop.Run();

        }
    }
}