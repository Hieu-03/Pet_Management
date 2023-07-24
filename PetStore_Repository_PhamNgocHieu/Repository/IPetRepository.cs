using PetStore_Repository_PhamNgocHieu.Models;
using System.Collections;

namespace PetStore_Repository_PhamNgocHieu.Repository
{
    public interface IPetRepository
    {
        IEnumerable<Pet> GetAllPets();
        Pet GetPetById(int id);
        void UpdatePet(Pet pet);
        void DeletePet(int id);
        void AddPet(Pet pet);
        IEnumerable<PetGroup> GetGroups();
        IEnumerable<Pet> SearchPetsByPrice(string price);
        IEnumerable<Pet> SearchPetsByQuantity(string quantity);
    }
}
