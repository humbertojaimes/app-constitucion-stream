using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MexicanConstitution.Mobile.Views;

public partial class SplashScreen : ContentPage
{
    public SplashScreen()
    {
        InitializeComponent();
    }

    

    private void SKLottieView_OnAnimationCompleted(object? sender, EventArgs e)
    {
        if(Application.Current is not null)
            Application.Current.Windows[0].Page = new AppShell();
    }
}