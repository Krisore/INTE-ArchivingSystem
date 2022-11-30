using AS.Server.Services.OrganizationService;
using AS.Shared;

namespace AS.Server.Services.ResearchService
{
    public class ResearchService : IResearchService
    {
        private readonly IOrganizationService _organizationService;

        public ResearchService(IOrganizationService organizationService)
        {
            _organizationService = organizationService;
        }
        public List<Research> Researches { get; set; } = new List<Research> 
        {
           new Research
                {
                    Id = 1,
                    OrganizationId = 1,
                    Title = "POLYTECHNIC UNIVERSITY OF THE PHILIPPINES - BIÑAN CAMPUS THESIS AND CAPSTONE ARCHIVING SYSTEM",
                    Abstract = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    PublishDate = DateTime.Today,
                },
           new Research
           {
                    Id = 2,
                    OrganizationId = 1,
                    Title = "POLYTECHNIC UNIVERSITY OF THE PHILIPPINES - BIÑAN CAMPUS QUEING SYSTEM",
                    Abstract = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    PublishDate = DateTime.Today,
           },
           new Research
           {
                    Id = 3,
                    OrganizationId = 1,
                    Title = "POLYTECHNIC UNIVERSITY OF THE PHILIPPINES - BIÑAN CAMPUS CHAT SYSTEM",
                    Abstract = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    PublishDate = DateTime.Today,
           },
           new Research
           {
                    Id = 4,
                    OrganizationId = 1,
                    Title = "POLYTECHNIC UNIVERSITY OF THE PHILIPPINES - BIÑAN CAMPUS INFORMATION SYSTEM",
                    Abstract = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    PublishDate = DateTime.Today,
           },
           new Research
           {
                    Id = 5,
                    OrganizationId = 1,
                    Title = "POLYTECHNIC UNIVERSITY OF THE PHILIPPINES - BIÑAN CAMPUS ROOM MANAGEMENT SYSTEM",
                    Abstract = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    PublishDate = DateTime.Today,
           },
        };

        public async Task<List<Research>> GetAllResearch()
        {
            return Researches;
        }
        public async Task<Research> GetResearch(int id)
        {
            Research research = Researches.FirstOrDefault(p => p.Id == id);
            return research;
        }

        public async Task<List<Research>> GetResearchByOrganization(string organizationUrl)
        {
            Organization organization = await _organizationService.GetOrganizationByUrl(organizationUrl);
            return Researches.Where(r => r.OrganizationId == organization.OrganizationId).ToList();
        }
    }
}
