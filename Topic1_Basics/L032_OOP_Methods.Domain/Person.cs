namespace L032_OOP_Methods.Domain
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
            Dormitory = new Dormitory(this);
            DormitoryId = Dormitory.DormitoryId;
        }

        public Person(string name, Dormitory dorm)
        {
            Name = name;
            Dormitory = dorm; 
            Dormitory.Persons.Add(this);
            DormitoryId = Dormitory.DormitoryId;
        }
        public Dormitory GetDorm()
        {
            return Dormitory;
        }

        public string Name { get; set; }

        internal Dormitory Dormitory { get; set; }

        public int DormitoryId { get; set; }

    }
}