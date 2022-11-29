using System.ComponentModel.DataAnnotations;

namespace Wishlist.Models
{
    public class Role
    {
        public Role() { }

        public Role(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
