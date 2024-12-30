using CommunityToolkit.Mvvm.ComponentModel;
using SkyCastRealtime.Model;
using System.Collections.ObjectModel;

namespace SkyCastRealtime.ViewModel;

internal partial class WeatherSummaryViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<AlertData> _weatherAlerts;


}
