using MexicanConstitution.Mobile.Views;

namespace MexicanConstitution.Mobile;

public partial class App : Application
{
    SplashScreen _splashScreen;
    public App(SplashScreen splashScreen)
    {
        InitializeComponent();
        _splashScreen = splashScreen;
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(_splashScreen);
    }
}