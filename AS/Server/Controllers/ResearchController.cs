using AS.Server.Services.ResearchService;
using AS.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResearchController : ControllerBase
    {
        private readonly IResearchService _researchService;

        public ResearchController(IResearchService researchService)
        {
            _researchService = researchService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Research>>> GetAllResearch() 
        {
            return Ok(await _researchService.GetAllResearch());
        }
        [HttpGet("Organization/{organizationUrl}")]
        public async Task<ActionResult<List<Research>>> GetResearchByOrganization(string organizationUrl) 
        {
                return Ok(await _researchService.GetResearchByOrganization(organizationUrl));
         
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Research>> GetResearch(int id) 
        {
            return Ok(await _researchService.GetResearch(id));
        }
    }
}
