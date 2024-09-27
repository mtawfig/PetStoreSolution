namespace PetStoreWebApp.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public string PhotoPath { get; set; }
    }
}