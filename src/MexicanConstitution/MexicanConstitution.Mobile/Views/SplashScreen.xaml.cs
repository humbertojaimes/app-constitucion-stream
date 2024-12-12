using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MexicanConstitution.Mobile.Views;

public partial class SplashScreen : ContentPage
{
    SplashViewModel _splashViewModel;
    Task initTask;
    public SplashScreen(SplashViewModel splashViewModel)
    {
        InitializeComponent();
        _splashViewModel = splashViewModel;
        BindingContext = _splashViewModel;
    }

    protected override void OnAppearing()
    {
       initTask = _splashViewModel.OnInitializingAsync();
    }

    private async void SKLottieView_OnAnimationCompleted(object? sender, EventArgs e)
    {
        await initTask;
        if(Application.Current is not null)
            Application.Current.Windows[0].Page = new AppShell();
       
    }
}