namespace L032_OOP_Methods.Domain
{
    public class Person
    {
        public Person()
        {
            Name = "nežinomas";
            DormId = 0;
        }

        public Person(string name, int dormId)
        {
            Name = name;
            DormId = dormId;
        }

        public string Name { get; set; }
        public int DormId { get; set; }
    }
}