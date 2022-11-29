namespace Wishlist.Models.Dto
{
    public class GetRolesDto
    {
        public GetRolesDto(Role role)
        {
            Id = role.Id;
            Name = role.Name;
            Description = role.Description;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
