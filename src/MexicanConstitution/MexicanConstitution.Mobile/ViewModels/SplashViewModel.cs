using MexicanConstitution.Mobile.Interfaces;

namespace MexicanConstitution.Mobile.ViewModels;

public class SplashViewModel : BaseViewModel
{
    private IConstitutionDataService _constitutionDataService;
    public SplashViewModel(IConstitutionDataService constitutionDataService)
    {
        
        _constitutionDataService = constitutionDataService;
    }
    
    public async Task OnInitializingAsync()
    {
        if (!IsBusy)
        {
            IsBusy = true;
            await _constitutionDataService.InitAsync();
            IsBusy = false;
        }
    }
    
}