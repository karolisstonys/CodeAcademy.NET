using L045_Generics.Interfaces;

namespace L045_Generics.Models
{
    public class BusinessClient : IUser
    {
        public BusinessClient() { }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
