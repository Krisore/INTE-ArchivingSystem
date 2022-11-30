using AS.Shared;

namespace AS.Server.Services.OrganizationService
{
    public interface IOrganizationService
    {
        Task<List<Organization>> GetOrganizations();
        Task<Organization> GetOrganizationByUrl(string organizationUrl);
    }
}
