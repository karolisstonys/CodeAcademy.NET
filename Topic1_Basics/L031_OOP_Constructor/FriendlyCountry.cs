namespace L031_OOP_Constructor
{
    public class FriendlyCountry
    {
        public FriendlyCountry()
        {
            Name = "unknown country";
        }

        public string Name { get; set; }
        public bool IsNeighbour { get; set; } = false;
        public string Government { get; set; } = "unknown goovernment";

    }
}