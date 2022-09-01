using L045_Generics.Interfaces;

namespace L045_Generics.Models
{
    public class Administrator : IUser
    {
        public Administrator() { }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
