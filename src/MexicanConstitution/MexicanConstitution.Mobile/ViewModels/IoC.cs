namespace MexicanConstitution.Mobile.ViewModels;

public static class IoC
{
    public static IServiceCollection AddViewModels(this IServiceCollection services)
    {
        services.AddTransient<SplashViewModel>();
        services.AddTransient<TitlesViewModel>();
        services.AddTransient<ArticlesViewModel>();
        services.AddTransient<ArticleContentViewModel>();
        return services;
    }
}