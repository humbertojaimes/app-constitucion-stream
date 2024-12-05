using System.Collections.ObjectModel;
using MexicanConstitution.Mobile.Interfaces;

namespace MexicanConstitution.Mobile.ViewModels;

public class ArticlesViewModel : BaseViewModel
{
    private IConstitutionDataService _constitutionDataService;
    
    public ArticlesViewModel(IConstitutionDataService constitutionDataService)
    {
        Title = Titles.page_articles;
        _constitutionDataService = constitutionDataService;
        
    }
    
    public async Task OnInitializingAsync()
    {
        if (!IsBusy)
        {
            IsBusy = true;
            var titles = await _constitutionDataService.GetTitlesAsync();
            ConstitutionTitles = new (titles);
            IsBusy = false;
        }
    }
    
    private ObservableCollection<Title> _titles;
    public ObservableCollection<Title> ConstitutionTitles
    {
        get => _titles;
        set => SetProperty(ref _titles, value);
    }
    
}