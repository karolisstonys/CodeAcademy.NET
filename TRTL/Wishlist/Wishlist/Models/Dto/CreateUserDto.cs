using Wishlist.Models.Enums;

namespace Wishlist.Models.Dto
{
    public class CreateUserDto
    {
        public CreateUserDto(User user)
        {
            Id = user.Id;
            Username = user.Username;
            Guid = user.Guid;
            Role = user.Role;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Guid { get; set; }
        public ERole Role { get; set; }
    }
}
