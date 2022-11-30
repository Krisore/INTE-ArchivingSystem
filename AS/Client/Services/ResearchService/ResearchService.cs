using AS.Shared;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System.Net.Http.Json;

namespace AS.Client.Services.ResearchService
{
    /// <summary>
    /// This is for research services that provide functional to load data or delete data.
    /// </summary>
    public class ResearchService : IResearchService
    {
        private readonly HttpClient _http;

        public event Action OnChange;

        public List<Research> Researches { get; set; } = new List<Research>();
        public ResearchService(HttpClient http)
        {
            _http = http;
        }
        public async Task LoadResearchs(string organizationUrl)
        {
            try
            {
                if (organizationUrl == null)
                {
                    Researches = await _http.GetFromJsonAsync<List<Research>>("api/Research");
                }
                else
                {
                    Researches = await _http.GetFromJsonAsync<List<Research>>($"api/Research/Organization/{organizationUrl}");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"{nameof(exception)}");
            }
            OnChange.Invoke();
        }

        public async Task<Research> GetProduct(int id)
        {
            return await _http.GetFromJsonAsync<Research>($"api/Research/{id}");
        }
    }
}
