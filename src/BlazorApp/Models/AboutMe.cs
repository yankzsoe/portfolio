namespace BlazorApp.Models;

public class AboutMe
{
    public string Description { get; set; } = string.Empty;
    public int? ExperienceStartYear { get; set; }
    public List<string> Skills { get; set; } = new();
    public string DetailOrQuote { get; set; } = string.Empty;
}
