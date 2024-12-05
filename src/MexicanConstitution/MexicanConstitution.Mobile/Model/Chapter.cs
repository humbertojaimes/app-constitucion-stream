namespace MexicanConstitution.Mobile.Model;

public class Chapter
{
    public string Name { get; set; }

    public string Content { get; set; }

    public string Description { get; set; }
    
    public IEnumerable<Article> Articles { get; set; }
}