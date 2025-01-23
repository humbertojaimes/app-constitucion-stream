using System.Text.Json;
using MexicanConstitution.Model;

namespace MexicanConstitution.Api.Routes;

public static class ConstitutionRoutes
{
    public static IEndpointRouteBuilder AddConstitutionRoutes(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/constitution");
        group.MapGet("/titles", GetTitles );
        return app;

        async Task<IEnumerable<Title>> GetTitles()
        {
            var jsonContent = await File.ReadAllTextAsync("Assets/constitution.json");
            var titles = JsonSerializer.Deserialize<IEnumerable<Title>>(jsonContent);
            return titles;
        }
        
    }
}