using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.Shared
{
    public class Organization
    {
        public int OrganizationId { get; set; }
        public string? Name { get; set; }
        public string? Acronym { get; set; }
        public string? Url { get; set; }
        public List<Research>? Documents { get; set; }
    }
}
