using L042_Practice.Enums;
using L042_Practice.Models.Abstract;
using L042_Practice.Models.Concrete;

namespace L042_Practice.Interfaces
{
    public interface IUniversityBookStore
    {
        public void Fill(string dataSeed);

        public void Buy(Book book, int qtty); // padidantis knygų prekyboje kiekį jei tokia knyga jau yra, arba įtraukiantis naują knygą

        public Invoice Sale(Person person, string title, BookType bookType, int qtty); // sumažinantis nurodytų knygų prekyboje kiekį


    }

}
