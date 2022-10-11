using DTOLayer;
using Patient.BusinessLayer.INTERFACE;
using Patient.BusinessLayer.MANAGER;
using System.Collections.Generic;
using System.Web.Http;

namespace Patient.Controllers
{
    public class PetController : ApiController
    {
        private readonly IPetManager petManager = null;
        public PetController(IPetManager petManager)
        {
            this.petManager = petManager;
        }
        public PetController()
        {
            this.petManager = new PetManager();
        }
        [HttpGet]
        public IHttpActionResult GetPets()
        {
            List<PetDto> pets = petManager.GetAllPets();
            return Ok(pets);
        }
        [HttpPost]
        public IHttpActionResult PostPet(PetDto pet)
        {
            if (petManager.AddPet(pet))
                return Ok();
            else return BadRequest();
        }

    }
}
