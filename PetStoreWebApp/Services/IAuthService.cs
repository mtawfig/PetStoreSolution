using PetStoreWebApp.Models;

namespace PetStoreWebApp.Services
{
    public interface IAuthService
    {
        User Authenticate(string username, string password);
        void Register(User user);
    }
}
