using System.Collections.ObjectModel;
using System.Windows.Input;
using MexicanConstitution.Mobile.Constants;
using MexicanConstitution.Mobile.Interfaces;

namespace MexicanConstitution.Mobile.ViewModels;

public class TitlesViewModel : BaseViewModel
{
    private IConstitutionDataService _constitutionDataService;
    public TitlesViewModel(IConstitutionDataService constitutionDataService)
    {
        Title = PagesTitles.page_titles;
        ConstitutionTitles = new(constitutionDataService.Titles);
        TitleSelectedCommand = new Command(async ()=> await OnTitleSelected());
    }
    
    private ObservableCollection<Title> _titles;
    public ObservableCollection<Title> ConstitutionTitles
    {
        get => _titles;
        set => SetProperty(ref _titles, value);
    }
    
    private Title _selectedTitle;
    
    public Title SelectedTitle
    {
        get => _selectedTitle;
        set => SetProperty(ref _selectedTitle, value);
    }
    
    public ICommand TitleSelectedCommand { get; private set; }
    
    private async Task OnTitleSelected()
    {
        if (SelectedTitle is null)
            return;
        else
        {
            await Shell.Current.GoToAsync($"{ARTICLES}?{TITLE_ID_PARAM}={SelectedTitle.Name}");
            SelectedTitle = null;
        }
    }
    
}