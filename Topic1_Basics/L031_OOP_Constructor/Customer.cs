namespace L031_OOP_Constructor
{
    internal class Customer
    {
        public Customer()
        {
            Vardas = "Stiuartas";
        }

        public Customer(string vardas)
        {
            Vardas = vardas;
        }

        public string Vardas { get; set; }
    }
}