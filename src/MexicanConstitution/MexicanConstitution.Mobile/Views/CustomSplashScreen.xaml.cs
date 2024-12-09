namespace MexicanConstitution.Mobile.Views;

public partial class CustomSplashScreen : ContentPage
{
	public CustomSplashScreen()
	{
		InitializeComponent();
	}

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        await Task.Delay(3900);

        App.Current.MainPage = new AppShell();
    }
}