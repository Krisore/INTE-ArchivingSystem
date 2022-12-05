using AS.Server.Services.ResearchService;
using AS.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService _researchService;

        public DocumentController(IDocumentService researchService)
        {
            _researchService = researchService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Research>>> GetAllDocument() 
        {
            return Ok(await _researchService.GetAllDocument());
        }
        [HttpGet("Organization/{organizationUrl}")]
        public async Task<ActionResult<List<Research>>> GetDocumentByOrganization(string organizationUrl) 
        {
                return Ok(await _researchService.GetDocumentByOrganization(organizationUrl));
         
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Research>> GetDocument(int id) 
        {
            return Ok(await _researchService.GetDocument(id));
        }
    }
}
