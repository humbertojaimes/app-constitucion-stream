using System;
using MexicanConstitution.Mobile.Constants;

namespace MexicanConstitution.Mobile.ViewModels;

public class ArticleContentViewModel : BaseViewModel, IQueryAttributable
{

    public void ApplyQueryAttributes(IDictionary<string, object> navigationParameters)
    {
        if (navigationParameters.ContainsKey(ParamsIdentifiers.ARTICLE_CONTENT_PARAM))
        {
            ArticleContent = navigationParameters[ParamsIdentifiers.ARTICLE_CONTENT_PARAM] as Article;
        }
        Title = ArticleContent?.Name;

    } 

    public Article ArticleContent 
    { 
        get => field; //field is a preview feature in C# 13
        set => SetProperty(ref field, value); 
    }

}
