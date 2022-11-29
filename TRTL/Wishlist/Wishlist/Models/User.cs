using System.ComponentModel.DataAnnotations;
using Wishlist.Models.Enums;

namespace Wishlist.Models
{
    public class User
    {
        public User() { }

        public User(int id, string username, string password, string guid, ERole role)
        {
            Id = id;
            Username = username;
            Password = password;
            Guid = guid;
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            Role = role;
        }

        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Guid { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public ERole Role { get; set; }
    }

}
