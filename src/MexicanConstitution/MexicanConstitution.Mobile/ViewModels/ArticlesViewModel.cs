using System.Collections.ObjectModel;
using MexicanConstitution.Mobile.Interfaces;

namespace MexicanConstitution.Mobile.ViewModels;

[QueryProperty(nameof(ArticlesViewModel.TitleId),TITLE_ID_PARAM)]
public class ArticlesViewModel : BaseViewModel
{
    private IConstitutionDataService _constitutionDataService;
    private Title _title;
    
    public ArticlesViewModel(IConstitutionDataService constitutionDataService)
    {
        Title = PagesTitles.page_articles;
        _constitutionDataService = constitutionDataService;
    }
    public string TitleId
    {
        get => field;
        set
        {
            field = value;
            LoadArticles(value);
        }
    }
    

    public ObservableCollection<Chapter> Chapters
    {
        get => field;
        set => SetProperty(ref field, value);
    }
    
    private async Task LoadArticles(string titleId)
    {
        //ArgumentException.ThrowIfNullOrWhiteSpace(titleId);
        if (string.IsNullOrEmpty(titleId))
           await Shell.Current.GoToAsync("..");
        else
        {
            _title = _constitutionDataService.Titles.FirstOrDefault(t => t.Name.Trim().Equals(titleId));
            if (_title is not null)
            {
                Chapters = new(_title.Chapters);
                Title = _title.Name;
            }
            
        }
    }
    
}