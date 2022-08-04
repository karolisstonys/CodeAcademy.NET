namespace L030_OOP_Composition
{
    public class Release
    {
        private DateOnly date;

        public DateOnly Date
        {
            get { return date; }
            set { date = value; }
        }

        private string publisher;

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        private string coverType;

        public string CoverType
        {
            get { return coverType; }
            set { coverType = value; }
        }

    }
}