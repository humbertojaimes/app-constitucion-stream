namespace MexicanConstitution.Model;

public class Chapter
{
    public string Name { get; set; }

    public string Description { get; set; }
    
    public List<Article> Articles { get; set; }
}