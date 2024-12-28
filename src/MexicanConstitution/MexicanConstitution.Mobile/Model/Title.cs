namespace MexicanConstitution.Mobile.Model;

public class Title 
{
    public string Name { get; set; }

    public string Description { get; set; }
    
    
    public IEnumerable<Chapter> Chapters { get; set; }
}