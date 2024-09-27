using Microsoft.AspNetCore.Mvc;
using PetStoreWebApp.Models;
using PetStoreWebApp.Services;

namespace PetStoreWebApp.Controllers
{
    public class PetController : Controller
    {
        private readonly IPetService _petService;

        public PetController(IPetService petService)
        {
            _petService = petService;
        }

        public IActionResult Index() => View(_petService.GetAllPets());

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Pet pet, IFormFile photo)
        {
            _petService.CreatePet(pet, photo);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id) => View(_petService.GetPetById(id));

        [HttpPost]
        public IActionResult Edit(Pet pet, IFormFile photo)
        {
            _petService.UpdatePet(pet, photo);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id) => View(_petService.GetPetById(id));

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _petService.DeletePet(id);
            return RedirectToAction("Index");
        }
    }
}
