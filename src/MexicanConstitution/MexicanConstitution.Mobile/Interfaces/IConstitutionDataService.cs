using System.Collections;

namespace MexicanConstitution.Mobile.Interfaces;

public interface IConstitutionDataService
{
    Task<IEnumerable<Title>> GetTitlesAsync();
}