using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MexicanConstitution.Mobile.Views;

public partial class ArticlesPage : ContentPage
{
    public ArticlesPage(ArticlesViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected async override void OnAppearing()
    {
        (BindingContext as ArticlesViewModel)?.OnInitializingAsync();
    }
}