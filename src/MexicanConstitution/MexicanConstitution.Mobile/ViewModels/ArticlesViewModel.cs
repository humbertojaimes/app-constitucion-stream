using System.Collections.ObjectModel;
using MexicanConstitution.Mobile.Constants;
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
        ArticleSelectedCommand = new(async () => await OnArticleSelected());
    }

    public Command ArticleSelectedCommand { get; set; }
    public string TitleId
    {
        get => field; //field is a preview feature in C# 13
        set
        {
            field = value;
            LoadArticles(value);
        }
    }

    public Article Article
    {
        get => field; //field is a preview feature in C# 13
        set => SetProperty(ref field, value);
    }
    

    public ObservableCollection<ChapterViewModel> Chapters
    {
        get => field; //field is a preview feature in C# 13
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
                Title = _title.Name;

                var chapters = _title.Chapters.Select(c => new ChapterViewModel(c)).ToList();
                Chapters = new(chapters);
            }
            
        }
    }

    private Task OnArticleSelected()
    {
        var parameters = new Dictionary<string, object>
        {
            [ARTICLE_CONTENT_PARAM] = Article
        };
        return Shell.Current.GoToAsync($"{ARTICLE_CONTENT}", parameters);
    }
    
}