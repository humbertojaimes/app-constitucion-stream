using System.Net.Http.Json;

namespace MexicanConstitution.Mobile.Services.RestClients;

public class ConstitutionRestClient(HttpClient client)
{
    public async Task<IEnumerable<Title>> GetTitlesAsync()
    {
        try
        {
            var response = await client.GetAsync("");
        

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<IEnumerable<Title>>();
        }
        else
        {
            return null;
        }
        }
        catch(Exception e)
        {
            return null;
        }
    }
    
}