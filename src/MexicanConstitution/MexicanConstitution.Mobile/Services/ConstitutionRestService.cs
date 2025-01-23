using System.Net.Http.Json;
using MexicanConstitution.Mobile.Interfaces;
using MexicanConstitution.Mobile.Services.RestClients;

namespace MexicanConstitution.Mobile.Services;

public class ConstitutionRestService(ConstitutionRestClient constitutionRestClient): IConstitutionDataService
{
    private string _id;
    private readonly HttpClient _client;
    
    public async Task InitAsync()
    {
        Titles = await constitutionRestClient.GetTitlesAsync();
    }

    public IEnumerable<Title> Titles { get; private set; }
}