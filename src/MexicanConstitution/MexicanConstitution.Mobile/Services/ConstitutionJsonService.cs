using System.Text.Json;
using MexicanConstitution.Mobile.Interfaces;

namespace MexicanConstitution.Mobile.Services;

public class ConstitutionJsonService : IConstitutionDataService
{
    public async Task InitAsync()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("constitution.json");
        using var reader = new StreamReader(stream);
        var jsonContent = reader.ReadToEnd();
        
        _titles = JsonSerializer.Deserialize<IEnumerable<Title>>(jsonContent);
    }

    private IEnumerable<Title> _titles;
    
    public IEnumerable<Title> Titles => _titles;
    
}