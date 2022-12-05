using AS.Shared;

namespace AS.Server.Services.ResearchService
{
    public interface IDocumentService
    {
        Task<List<Research>> GetAllDocument();
        Task<List<Research>> GetDocumentByOrganization(string organizationUrl);
        Task<Research> GetDocument(int organizationUrl);
    }
}
