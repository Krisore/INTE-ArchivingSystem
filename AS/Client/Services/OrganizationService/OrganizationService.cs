using AS.Shared;
using System.Net.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace AS.Client.Services.OrganizationService
{
    public class OrganizationService : IOrganizationService
    {
        private readonly HttpClient _http;
        public List<Organization> Organizations { get; set; } = new List<Organization>();
        public OrganizationService(HttpClient http)
        {
            _http = http;
        }
        public async Task LoadOrganizations()
        { 
            try
            {
                Organizations = await _http.GetFromJsonAsync<List<Organization>>("api/Organization");
            }
            catch (AccessTokenNotAvailableException exception)
            {
            
            }
        }
    }
}
