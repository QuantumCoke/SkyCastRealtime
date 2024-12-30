using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
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
}
