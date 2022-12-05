using AS.Shared;

namespace AS.Client.Services.ResearchService
{
    public interface IDocumentService
    {
        event Action OnChange;
        List<Research> Researches { get; set; }
        Task LoadDocuments(string categoryUrl = null);
        Task<Research> GetResearch(int id);
    }
}
