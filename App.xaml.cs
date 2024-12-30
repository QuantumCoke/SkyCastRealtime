using Microsoft.Extensions.DependencyInjection;
using SkyCastRealtime.Service;
using SkyCastRealtime.View;
using SkyCastRealtime.ViewModel;
using System.Windows;

namespace SkyCastRealtime;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    /// <summary>
    /// App
    /// </summary>
    public new static App Current => (App)Application.Current;

    /// <summary>
    /// 의존성 주입 객체
    /// </summary>
    public IServiceProvider ServiceProvider { get; private set; }

    /// <summary>
    /// 시작 설정
    /// </summary>
    /// <param name="e"></param>
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        var services = new ServiceCollection();
        ConfigureServices(services);

        ServiceProvider = services.BuildServiceProvider();
        RegisterViewInNavigation();

        var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
        mainWindow.DataContext = ServiceProvider.GetRequiredService<MainViewModel>();
        mainWindow.Show();
    }

    /// <summary>
    /// view, viewmodel 등록
    /// </summary>
    /// <param name="services"></param>
    private void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<Navigator>();

        services.AddTransient<MainViewModel>();
        services.AddTransient<WeatherDetailViewModel>();
        services.AddTransient<WeatherSummaryViewModel>();
        services.AddTransient<WeatherAlertViewModel>();

        services.AddTransient<MainWindow>();
        services.AddTransient<WeatherDetailView>();
        services.AddTransient<WeatherSummaryView>();
        services.AddTransient<WeatherAlertView>();
    }

    /// <summary>
    /// viewmodel을 navigation 객체에 등록
    /// </summary>
    private void RegisterViewInNavigation()
    {
        var navigationService = ServiceProvider.GetRequiredService<Navigator>();

        navigationService.RegisterViewModel<WeatherDetailViewModel>("WeatherDetail");
        navigationService.RegisterViewModel<WeatherSummaryViewModel>("WeatherSummary");
        navigationService.RegisterViewModel<WeatherAlertViewModel>("WeatherAlert");
    }
}
