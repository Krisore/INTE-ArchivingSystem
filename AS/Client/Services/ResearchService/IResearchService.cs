using AS.Shared;

namespace AS.Client.Services.ResearchService
{
    public interface IResearchService
    {
        event Action OnChange;
        List<Research> Researches { get; set; }
        Task LoadResearchs(string categoryUrl = null);
        Task<Research> GetProduct(int id);
    }
}
