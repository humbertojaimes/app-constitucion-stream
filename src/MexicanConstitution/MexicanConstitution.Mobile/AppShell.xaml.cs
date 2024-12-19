using MexicanConstitution.Mobile.Constants;
using MexicanConstitution.Mobile.Views;

namespace MexicanConstitution.Mobile;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(PageIdentifiers.ARTICLES, typeof(ArticlesPage));
    }
}