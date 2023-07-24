using PetStore_Repository_PhamNgocHieu.Dao;
using PetStore_Repository_PhamNgocHieu.Models;
using System.Collections;

namespace PetStore_Repository_PhamNgocHieu.Repository
{
    public class PetRepository : IPetRepository
    {
        public Pet GetPetById(int id) => PetDbContext.Instance.GetPetById(id);
        public IEnumerable<Pet> GetAllPets() => PetDbContext.Instance.GetAllPets();
        public void DeletePet(int id) => PetDbContext.Instance.DeletePet(id);
        public void UpdatePet(Pet pet) => PetDbContext.Instance.UpdatePet(pet);
        public void AddPet(Pet pet) => PetDbContext.Instance.AddPet(pet);
        public IEnumerable<Pet> SearchPetsByPrice(string price) => PetDbContext.Instance.SearchPetsByPrice(price);
        public IEnumerable<Pet> SearchPetsByQuantity(string quantity) => PetDbContext.Instance.SearchPetsByQuantity(quantity);
        public IEnumerable<PetGroup> GetGroups() => PetDbContext.Instance.GetPetGroups();
    }
}
