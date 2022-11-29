using System.ComponentModel.DataAnnotations;
namespace AS.Shared
{
    public class Research
    {
        [Required]
        public int ResearchId { get; set; }
        [Required]
        public string? Title { get; set; }
        public List<Author> Authors { get; set; } = new List<Author>();
    }

}