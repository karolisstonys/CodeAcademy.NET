namespace Wishlist.Services.Interfaces
{
    public interface IPasswordService
    {
        string HashPassword(string password, byte[] salt = null, bool needsOnlyHash = false);

        bool VerifyPassword(string hashedPasswordWithSalt, string passwordToCheck);
    }
}
