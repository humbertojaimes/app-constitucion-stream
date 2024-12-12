using System.Collections;

namespace MexicanConstitution.Mobile.Interfaces;

public interface IConstitutionDataService
{
    Task InitAsync();
    IEnumerable<Title> Titles { get; } 
}