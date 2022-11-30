using Wishlist.Models.Enums;

namespace Wishlist.Models.Dto
{
    public class GetUserDto
    {
        public GetUserDto(User user)
        {
            Id = user.Id;
            Username = user.Username;
            Guid = user.Guid;
            Role = user.Role.ToString();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Guid { get; set; }
        public string Role { get; set; }
    }
}
