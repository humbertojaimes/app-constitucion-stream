namespace MexicanConstitution.Mobile;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new Views.CustomSplashScreen();
    }

  /*  protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
    } */
}