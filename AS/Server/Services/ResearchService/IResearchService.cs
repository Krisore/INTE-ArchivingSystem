using AS.Shared;

namespace AS.Server.Services.ResearchService
{
    public interface IResearchService
    {
        Task<List<Research>> GetAllResearch();
        Task<List<Research>> GetResearchByOrganization(string organizationUrl);
        Task<Research> GetResearch(int organizationUrl);
    }
}
