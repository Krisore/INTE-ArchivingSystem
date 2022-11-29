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
        public List<Author>? Authors { get; set; }
        public string? DocumentFile { get; set; }
        public DateTime PublishDate { get; set; }
        public Organization? Organization { get; set; }
        public bool IsOpenAccess { get; set; }
    }
}
