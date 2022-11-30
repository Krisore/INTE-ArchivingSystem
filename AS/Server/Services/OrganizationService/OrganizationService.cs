using AS.Shared;

namespace AS.Server.Services.OrganizationService
{
    public class OrganizationService : IOrganizationService
    {
        public List<Organization> Organizations { get; set; } = new List<Organization>
        {
                new Organization 
                {
                    OrganizationId = 1,
                    Name = "Institute of Bachelors in Information Technology - PUPBC", 
                    Acronym ="IBITS", 
                    Url="ibits"
                },
                new Organization 
                {
                    OrganizationId = 2, 
                    Name = "Human Resource Students Society - PUPBC", 
                    Acronym ="HRSS", 
                    Url="hrss"
                },
                new Organization 
                {
                    OrganizationId = 3, 
                    Name = "Young Educators Society - PUPBC", 
                    Acronym ="YES", 
                    Url = "yes"
                },
                new Organization 
                {
                    OrganizationId = 4, 
                    Name = "Association of Computer Engineering Students - PUPBC", 
                    Acronym ="ACES", 
                    Url = "aces"
                },
                new Organization 
                {
                    OrganizationId = 5, 
                    Name = "Junior Philippine Institure of Accountants - PUPBC", 
                    Acronym = "JPIA", 
                    Url = "jpia"
                }
        };

        public async Task<Organization> GetOrganizationByUrl(string organizationUrl)
        {
            return Organizations.FirstOrDefault(o => o.Url.ToLower().Equals(organizationUrl.ToLower()));
        }

        public async Task<List<Organization>> GetOrganizations()
        {
            return Organizations;
        }
    }
}
