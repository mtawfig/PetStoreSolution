using PetStoreWebApp.Models;
using PetStoreWebApp.Repositories;

namespace PetStoreWebApp.Services
{
    public class PetService : IPetService
    {
        private readonly IPetRepository _petRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PetService(IPetRepository petRepository, IWebHostEnvironment webHostEnvironment)
        {
            _petRepository = petRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        public IEnumerable<Pet> GetAllPets() => _petRepository.GetAll();

        public Pet GetPetById(int id) => _petRepository.GetById(id);

        public void CreatePet(Pet pet, IFormFile photo)
        {
            pet.PhotoPath = SavePhoto(photo);
            _petRepository.Add(pet);
        }

        public void UpdatePet(Pet pet, IFormFile photo)
        {
            if (photo != null)
            {
                pet.PhotoPath = SavePhoto(photo);
            }
            _petRepository.Update(pet);
        }

        public void DeletePet(int id) => _petRepository.Delete(id);

        private string SavePhoto(IFormFile photo)
        {
            if (photo != null && photo.Length > 0)
            {
                var uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                var uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
                var filePath = Path.Combine(uploadFolder, uniqueFileName);
                using var fileStream = new FileStream(filePath, FileMode.Create);
                photo.CopyTo(fileStream);
                return "/uploads/" + uniqueFileName;
            }
            return null;
        }
    }
}
