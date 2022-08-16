namespace L034_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        private static void Examples()
        {
            Console.WriteLine("Hello, Enums!");
            EDaysOfWeek today = EDaysOfWeek.Tuesday;
            Console.WriteLine($"today is {today}");

            int todayInt = (int)EDaysOfWeek.Tuesday;
            Console.WriteLine($"todayInt is {todayInt}");

            int todayTwo = 2;
            EDaysOfWeek todayNumber = (EDaysOfWeek)todayTwo;
            Console.WriteLine($"todayNumber is {todayNumber}");

            // -------------------------------------------------------
            // statines klases enuveracijos

            int today3 = DayOfWeekEnum.Tuesday;
        }
    }

    public enum EDaysOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }


    public  class CustomEnum
    {
        public CustomEnum(int id, string name)
        {
            Id=id;
            Name=name;
        }

        public int Id { get; set; }
        public string Name { get; set; }


        public override string ToString() => Name;

    }

    public class DaysOfWeekCustomEnum
    {
        public static CustomEnum Sunday => new CustomEnum(1, nameof(Sunday));
        public static CustomEnum Monday => new CustomEnum(2, nameof(Monday));
        public static CustomEnum Tuesday => new CustomEnum(3, nameof(Tuesday));
        public static CustomEnum Wednesday => new CustomEnum(4, nameof(Wednesday));
        public static CustomEnum Thursday => new CustomEnum(5, nameof(Thursday));
        public static CustomEnum Friday => new CustomEnum(6, nameof(Friday));
        public static CustomEnum Saturday => new CustomEnum(7, nameof(Saturday));
    }


}