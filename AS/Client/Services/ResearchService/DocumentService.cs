using AS.Shared;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System.Net.Http.Json;

namespace AS.Client.Services.ResearchService
{
    /// <summary>
    /// This is for research services that provide functional to load data or delete data.
    /// </summary>
    public class DocumentService : IDocumentService
    {
        private readonly HttpClient _http;

        public event Action OnChange;

        public List<Research> Researches { get; set; } = new List<Research>();
        public DocumentService(HttpClient http)
        {
            _http = http;
        }
        public async Task LoadDocuments(string organizationUrl)
        {
            try
            {
                if (organizationUrl == null)
                {
                    Researches = await _http.GetFromJsonAsync<List<Research>>("api/Document");
                }
                else
                {
                    Researches = await _http.GetFromJsonAsync<List<Research>>($"api/Document/Organization/{organizationUrl}");
                }
            }
            catch (Exception exception)
            {
               
            }
            OnChange.Invoke();
        }

        public async Task<Research> GetResearch(int id)
        {
            return await _http.GetFromJsonAsync<Research>($"api/Document/{id}");
        }
    }
}
