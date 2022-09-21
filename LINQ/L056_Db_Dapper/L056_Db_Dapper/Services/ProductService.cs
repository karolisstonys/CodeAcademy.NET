using L056_Db_Dapper.Database;
using L056_Db_Dapper.Database.Dapper;
using L056_Db_Dapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L056_Db_Dapper.Services
{
    public class ProductService : IProductService
    {
        private readonly DatabaseConfig _databaseConfig;
        private readonly IProductRepository _productRepository;

        public ProductService()
        {
            _databaseConfig = new DatabaseConfig();
            _productRepository = new ProductRepository(_databaseConfig);
        }

        public void Run()
        {
            char selection;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. List all products");
                Console.WriteLine("3. Remove product by name");
                Console.WriteLine("q. Quit");

                selection = Console.ReadKey().KeyChar;

                switch (selection)
                {
                    case '1':
                        AddProduct();
                        break;
                    case '2':
                        DisplayProducts();
                        break;
                    case '3':
                        break;
                    case 'q' or 'Q':
                        return;
                    default:
                        break;
                }

            PauseScreen();




            }
        }

        public void DisplayProducts()
        {
            var products = _productRepository.Get();
            Console.WriteLine();

            foreach (var product in products)
            {
                Console.WriteLine($"ID:{product.Id} Name:{product.Name} Description:{product.Description} ");
            }
        }

        public void AddProduct()
        {
            var newProduct = new Product();
            Console.WriteLine("Enter product name:");
            newProduct.Name = Console.ReadLine();
            Console.WriteLine("Enter product description:");
            newProduct.Description = Console.ReadLine();

            _productRepository.Create(newProduct);

            Console.WriteLine($"New product added: {newProduct.Name} - {newProduct.Description}");


        }

        private void PauseScreen()
        {
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }


    }
}
