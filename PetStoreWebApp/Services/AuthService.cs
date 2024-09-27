using PetStoreWebApp.Data;
using PetStoreWebApp.Models;

namespace PetStoreWebApp.Services
{
    public class AuthService : IAuthService
    {
        private readonly PetStoreDbContext _context;

        public AuthService(PetStoreDbContext context)
        {
            _context = context;
        }

        public User Authenticate(string username, string password)
        {
            // Authenticate user by checking username and password in the database
            return _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public void Register(User user)
        {
            // Add new user to the database
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}