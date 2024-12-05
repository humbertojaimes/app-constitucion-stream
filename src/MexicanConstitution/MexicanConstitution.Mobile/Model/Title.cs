namespace MexicanConstitution.Mobile.Model;

public class Title 
{
    public string Name { get; set; }

    public string Content { get; set; }

    public string Description { get; set; }
    
    public override string ToString() => Name;
    
    public IEnumerable<Chapter> Chapters { get; set; }
}