using DTOLayer;
using Patient.BusinessLayer.OwnerBusiness;
using System.Collections.Generic;
using System.Web.Http;

namespace Patient.Controllers
{
    public class OwnerController : ApiController
    {
        private readonly IOwnerManager ownerManager = null;
        public OwnerController(IOwnerManager ownerManager)
        {
            this.ownerManager = ownerManager;
        }
        public OwnerController()
        {
            this.ownerManager = new OwnerManager();
        }
        [HttpGet]
        public IHttpActionResult GetOwners()
        {
            List<OwnerDto> owners = ownerManager.GetAllOwners();
            return Ok(owners);
        }
        [HttpPost]
        public IHttpActionResult PostOwner(OwnerDto owner)
        {
            if (ownerManager.AddOwner(owner))
                return Ok();
            else return BadRequest();
        }
    }
}
