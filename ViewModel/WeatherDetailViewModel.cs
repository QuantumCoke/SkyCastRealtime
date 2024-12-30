using CommunityToolkit.Mvvm.ComponentModel;
using SkyCastRealtime.Model;
using System.Collections.ObjectModel;

namespace SkyCastRealtime.ViewModel;

internal partial class WeatherDetailViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<AlertData> _weatherDetail;
}
