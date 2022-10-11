using Patients.DALayer.MODELS.ENTITIES;
using System.Collections.Generic;

namespace Repository.PetRepo
{
    public interface IPetRepo
    {
        List<Pet> GetAllPets();
        bool AddPet(Pet pet);
        bool GetPetById(long id);
    }
}
