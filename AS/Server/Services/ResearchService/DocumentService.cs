using AS.Server.Services.OrganizationService;
using AS.Shared;

namespace AS.Server.Services.ResearchService
{
    public class DocumentService : IDocumentService
    {
        private readonly IOrganizationService _organizationService;

        public DocumentService(IOrganizationService organizationService)
        {
            _organizationService = organizationService;
        }
        public List<Research> Researches { get; set; } = new List<Research>
        {
           new Research
                {
                    Id = 1,
                    OrganizationId = 1,
                     Authors = new List<Author>
                     {
                        new Author
                        {
                            Id = 1,
                            FirstName = "Kristian Paul",
                            LastName = "Enore",
                            MiddleInitial = "D"

                        },
                        new Author
                        {
                            Id = 2,
                            FirstName = "James",
                            LastName = "Advincula",
                            MiddleInitial = "D"

                        },
                        new Author
                        {
                            Id = 3,
                            FirstName = "Paula",
                            LastName = "Salazar",
                            MiddleInitial = "M"

                        },
                     },
                    Adviser = new Adviser
                    {
                        Id = 1,
                        Name = "Michael Angelo Miguel "
                    },
                    Title = "POLYTECHNIC UNIVERSITY OF THE PHILIPPINES - BIÑAN CAMPUS THESIS AND CAPSTONE ARCHIVING SYSTEM",
                    Abstract = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    PublishDate = DateTime.Today,
                },
           new Research
           {
                    Id = 2,
                    OrganizationId = 1,
                    Authors = new List<Author>
                    {
                        new Author 
                        {
                            Id = 1,
                            FirstName = "Catherine",
                            LastName = "Intal",
                            MiddleInitial = "M"

                        },
                        new Author
                        {
                            Id = 2,
                            FirstName = "Jaypee",
                            LastName = "Macalalad",
                            MiddleInitial = "M"

                        },
                        new Author
                        {
                            Id = 3,
                            FirstName = "Angeliko",
                            LastName = "Centeno",
                            MiddleInitial = "J"

                        },
                    },
                    Adviser = new Adviser
                    {
                        Id = 1,
                        Name = "Michael Angelo Miguel "
                    },
                    Title = "POLYTECHNIC UNIVERSITY OF THE PHILIPPINES - BIÑAN CAMPUS QUEING SYSTEM",
                    Abstract = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    PublishDate = DateTime.Today,
           },
           new Research
           {
                    Id = 3,
                    OrganizationId = 1,
                     Authors = new List<Author>
                    {
                        new Author
                        {
                            Id = 1,
                            FirstName = "Kian",
                            LastName = "Magdamit",
                            MiddleInitial = "K"

                        },
                        new Author
                        {
                            Id = 2,
                            FirstName = "Franz Isaac",
                            LastName = "Maaba",
                            MiddleInitial = "M"

                        },
                        new Author
                        {
                            Id = 3,
                            FirstName = "Guilbert",
                            LastName = "Lobrio",
                            MiddleInitial = "D"

                        },
                    },
                    Adviser = new Adviser
                    {
                        Id = 1,
                        Name = "Michael Angelo Miguel "
                    },
                    Title = "POLYTECHNIC UNIVERSITY OF THE PHILIPPINES - BIÑAN CAMPUS CHAT SYSTEM",
                    Abstract = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    PublishDate = DateTime.Today,
           },
           new Research
           {
                    Id = 4,
                    OrganizationId = 1,
                     Authors = new List<Author>
                    {
                        new Author
                        {
                            Id = 3,
                            FirstName = "Angeliko",
                            LastName = "Centeno",
                            MiddleInitial = "J"

                        },
                        new Author
                        {
                            Id = 1,
                            FirstName = "Catherine",
                            LastName = "Intal",
                            MiddleInitial = "M"

                        },
                        new Author
                        {
                            Id = 3,
                            FirstName = "Guilbert",
                            LastName = "Lobrio",
                            MiddleInitial = "D"

                        },
                    },
                    Adviser = new Adviser
                    {
                        Id = 1,
                        Name = "Michael Angelo Miguel "
                    },
                    Title = "POLYTECHNIC UNIVERSITY OF THE PHILIPPINES - BIÑAN CAMPUS INFORMATION SYSTEM",
                    Abstract = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    PublishDate = DateTime.Today,
           },
           new Research
           {
                    Id = 5,
                    OrganizationId = 1,
                     Authors = new List<Author>
                    {
                        new Author
                        {
                            Id = 1,
                            FirstName = "Kristian Paul",
                            LastName = "Enore",
                            MiddleInitial = "D"

                        },
                        new Author
                        {
                            Id = 3,
                            FirstName = "Guilbert",
                            LastName = "Lobrio",
                            MiddleInitial = "D"

                        },
                        new Author
                        {
                            Id = 2,
                            FirstName = "James",
                            LastName = "Advincula",
                            MiddleInitial = "D"

                        },
                    },
                    Adviser = new Adviser
                    {
                        Id = 1,
                        Name = "Michael Angelo Miguel "
                    },
                    Title = "POLYTECHNIC UNIVERSITY OF THE PHILIPPINES - BIÑAN CAMPUS ROOM MANAGEMENT SYSTEM",
                    Abstract = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    PublishDate = DateTime.Today,
           },
        };

        public async Task<List<Research>> GetAllDocument()
        {
            return Researches;
        }
        public async Task<Research> GetDocument(int id)
        {
            Research research = Researches.FirstOrDefault(p => p.Id == id);
            return research;
        }

        public async Task<List<Research>> GetDocumentByOrganization(string organizationUrl)
        {
            Organization organization = await _organizationService.GetOrganizationByUrl(organizationUrl);
            return Researches.Where(r => r.OrganizationId == organization.OrganizationId).ToList();
        }
        public IEnumerable<Research> GetDocumentBySearchTerm(string searchTerm) //TODO: Get Document by Search term
        {
            if (searchTerm == null) return Researches;
            return Researches.Where(r => r.Abstract.ToLower().Contains(searchTerm));
        }
    }
}
