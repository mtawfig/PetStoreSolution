using PetStoreWebApp.Models;

namespace PetStoreWebApp.Repositories
{
    public interface IPetRepository
    {
        IEnumerable<Pet> GetAll();
        Pet GetById(int id);
        void Add(Pet pet);
        void Update(Pet pet);
        void Delete(int id);
    }
}