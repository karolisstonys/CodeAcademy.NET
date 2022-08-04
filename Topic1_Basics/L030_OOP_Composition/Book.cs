namespace L030_OOP_Composition
{
    public class Book
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private string genre;

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        private int pageCount;

        public int PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }

        private Release release;

        public Release Release
        {
            get { return release; }
            set { release = value; }
        }


    }
}