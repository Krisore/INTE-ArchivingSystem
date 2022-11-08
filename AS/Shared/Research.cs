namespace AS.Shared;

public class Research
{
    public string? Title { get; set; }
    public List<Author> Authors { get; set; }
    public string? Abstract { get; set; }
    public DateTime DatePublish { get; set; }

    public ResearchStatus status { get; set; }

    public Research Format { get; set; }
}