using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.Shared
{
    public class Research
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Abstract { get; set; }
        public string? Url { get; set; }
        public List<Author>? Authors { get; set; } = new List<Author>();
        public Adviser Adviser { get; set; } = new Adviser();
        public string? DocumentFile { get; set; }
        public DateTime PublishDate { get; set; }
        public int OrganizationId { get; set; }
        public Organization? Organization { get; set; }
        public bool IsOpenAccess { get; set; }
        public bool IsDeleted { get; set; }
    }
}
