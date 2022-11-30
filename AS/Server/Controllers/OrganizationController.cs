using AS.Server.Services.OrganizationService;
using AS.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        private readonly IOrganizationService _organizationService;

        public OrganizationController(IOrganizationService organizationService)
        {
            _organizationService = organizationService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Organization>>> GetOrganization()
        {
            return Ok(await _organizationService.GetOrganizations());
        }
        
    }
}
