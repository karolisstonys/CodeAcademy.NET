using Wishlist.Services.Interfaces;

namespace Wishlist.Services
{
    public class GuidService : IGuidService
    {
        public string GetNewGuid() => Guid.NewGuid().ToString();        
    }
}
