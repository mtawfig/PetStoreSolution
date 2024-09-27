using PetStoreWebApp.Models;

namespace PetStoreWebApp.Services
{
    public interface IPetService
    {
        IEnumerable<Pet> GetAllPets();
        Pet GetPetById(int id);
        void CreatePet(Pet pet, IFormFile photo);
        void UpdatePet(Pet pet, IFormFile photo);
        void DeletePet(int id);
    }

}
