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
        _constitutionDataService = constitutionDataService;
        ConstitutionTitles = new(constitutionDataService.Titles);
        TitleSelectedCommand = new Command(async ()=> await OnTitleSelected());
        ArticleSelectedCommand = new Command(async ()=> await OnArticleSelected());
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
    
    private string _article;

    public string Article
    {
        get => _article;
        set => SetProperty(ref _article, value);
    }
    
    public ICommand TitleSelectedCommand { get; private set; }

    public ICommand ArticleSelectedCommand { get; private set; }
    
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

    private async Task OnArticleSelected()
    {
        if (string.IsNullOrWhiteSpace(Article))
            return;
        else
        {
            var articleContent = _constitutionDataService.Titles
                                    .SelectMany(t => t.Chapters)
                                    .SelectMany(c => c.Articles)
                                    .FirstOrDefault(a => a.Name.Trim().Equals(Article));

            if (articleContent is not null)
            {
                var parameters = new Dictionary<string, object>
                {
                    { ARTICLE_CONTENT_PARAM, articleContent }
                };

                await Shell.Current.GoToAsync($"{ARTICLE_CONTENT}",parameters);
                articleContent = null;
            }

            
        }
    }
    
}