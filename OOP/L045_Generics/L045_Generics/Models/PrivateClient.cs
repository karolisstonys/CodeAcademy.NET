using L045_Generics.Interfaces;

namespace L045_Generics.Models
{
    public class PrivateClient : IUser
    {
        public PrivateClient() { }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
