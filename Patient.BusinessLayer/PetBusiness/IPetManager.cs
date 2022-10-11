using DTOLayer;
using System.Collections.Generic;

namespace Patient.BusinessLayer.INTERFACE
{
    public interface IPetManager
    {
        List<PetDto> GetAllPets();
        bool AddPet(PetDto p);

    }
}
