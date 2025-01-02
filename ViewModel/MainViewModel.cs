using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using SkyCastRealtime.Model;
using SkyCastRealtime.Service;

namespace SkyCastRealtime.ViewModel;

internal partial class MainViewModel : ObservableObject
{
    /// <summary>
    /// 현재 viewmnodel
    /// </summary>
    [ObservableProperty]
    private object _currentViewModel;

    /// <summary>
    /// Navigation 객체
    /// </summary>
    private Navigator navigationService;

    /// <summary>
    /// mainview 생성자
    /// </summary>
    public MainViewModel() : base()
    {
        navigationService = App.Current.ServiceProvider.GetRequiredService<Navigator>();
    }

    /// <summary>
    /// 네이게이션
    /// </summary>
    /// <param name="view"></param>
    [RelayCommand]
    private void Navigate(string view)
    {
        CurrentViewModel = navigationService.GetViewModelByName(view);
    }



    /// <summary>
    /// Test
    /// </summary>
    /// <param name="view"></param>
    [RelayCommand]
    private async Task Test()
    {
        WeatherApiService WeatherApiService = new WeatherApiService();
        var reponse = await WeatherApiService.GetRegionDataDataAsync("XEHCFIWGQlKae4sbPdHrnmHB0nf%2FbiVbotS7ERa%2FpqdlLC7f%2BaTCtywqmebhpCNjQDlRRuYzwk3eWRrqAF8m7Q%3D%3D", "1","10","JSON", "11B00000", "202501020600");

        WeatherData myDeserializedClass = JsonConvert.DeserializeObject<WeatherData>(reponse);

    }
}
