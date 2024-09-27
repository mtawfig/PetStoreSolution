using PetStoreWebApp.Data;
using PetStoreWebApp.Models;

namespace PetStoreWebApp.Repositories
{
    public class PetRepository : IPetRepository
    {
        private readonly PetStoreDbContext _context;

        public PetRepository(PetStoreDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Pet> GetAll() => _context.Pets.ToList();

        public Pet GetById(int id) => _context.Pets.Find(id);

        public void Add(Pet pet)
        {
            _context.Pets.Add(pet);
            _context.SaveChanges();
        }

        public void Update(Pet pet)
        {
            _context.Pets.Update(pet);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var pet = _context.Pets.Find(id);
            if (pet != null)
            {
                _context.Pets.Remove(pet);
                _context.SaveChanges();
            }
        }

    }
}
