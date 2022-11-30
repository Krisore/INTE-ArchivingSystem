using AS.Shared;

namespace AS.Client.Services.OrganizationService
{
    public interface IOrganizationService
    {
        public List<Organization> Organizations { get; set; }
        public Task LoadOrganizations();
    }
}
