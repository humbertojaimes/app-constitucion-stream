using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MexicanConstitution.Mobile.Views;

public partial class TitlesPage : ContentPage
{
    public TitlesPage(TitlesViewModel titlesViewModel)
    {
        InitializeComponent();
        BindingContext = titlesViewModel;
    }
}