using System;

namespace MexicanConstitution.Mobile.ViewModels;

public class ChapterViewModel : List<Article>
{
    public string Name { get; set; }

    public ChapterViewModel(Chapter chapter): base(chapter.Articles)
    {
        Name = chapter.Name;
    }


}
