using System.Collections.ObjectModel;
using MexicanConstitution.Mobile.Interfaces;

namespace MexicanConstitution.Mobile.ViewModels;

public class ArticlesViewModel : BaseViewModel
{
    private IConstitutionDataService _constitutionDataService;
    
    public ArticlesViewModel(IConstitutionDataService constitutionDataService)
    {
        Title = Titles.page_articles;
        ConstitutionTitles = new(constitutionDataService.Titles);
    }
    
    
    
    private ObservableCollection<Title> _titles;
    public ObservableCollection<Title> ConstitutionTitles
    {
        get => _titles;
        set => SetProperty(ref _titles, value);
    }
    
}