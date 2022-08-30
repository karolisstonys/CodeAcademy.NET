using L042_Practice.Models.Abstract;

namespace L042_Practice.Models.Concrete
{
    public class Invoice
    {
        public DateTime DateAndTimeOfSale { get; set; }

        public Person SoldToPerson { get; set; }

        public List<Book> ListOfBooksSold { get; set; }

        public double TotalPrice { get; set; }

        public void Send() // metodas kuris sąskaitą galės išsiųsti Sms, Email ir Post
        {

        }

    }

}
