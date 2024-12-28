namespace MexicanConstitution.Mobile.Views;

public partial class ArticleContentPage : ContentPage
{
	public ArticleContentPage(ArticleContentViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}