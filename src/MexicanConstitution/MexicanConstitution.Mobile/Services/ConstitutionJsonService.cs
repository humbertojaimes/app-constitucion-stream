using System.Text.Json;
using MexicanConstitution.Mobile.Interfaces;

namespace MexicanConstitution.Mobile.Services;

public class ConstitutionJsonService : IConstitutionDataService
{
    public async Task<IEnumerable<Title>> GetTitlesAsync()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("constitution.json");
        using var reader = new StreamReader(stream);
        var jsonContent = reader.ReadToEnd();
        
        return JsonSerializer.Deserialize<IEnumerable<Title>>(jsonContent);
    }
}