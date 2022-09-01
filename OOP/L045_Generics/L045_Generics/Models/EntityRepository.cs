using L045_Generics.Interfaces;

namespace L045_Generics.Models
{
    public class EntityRepository<T> where T : IUser //, new()
    {
        public void Add(T userToAdd)
        {
            Users.Add(userToAdd);
        }

        public void Remove(T userToRemove)
        {
            Users.Remove(userToRemove);
        }

        public void Print()
        {
            foreach (var user in Users)
            {
                Console.WriteLine($"{user.Id} {user.Name}");
            }
        }

        public List<T> Fetch()
        {
            return Users;
        }


        public T Fetch(int id)
        {
            return Users.Where(e => e.Id == id).FirstOrDefault();
        }

        public List<T> Users { get; set; } = new List<T>();
    }
}
