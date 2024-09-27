namespace PetStoreWebApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // For simplicity, plain text (not recommended for production)
    }
}
