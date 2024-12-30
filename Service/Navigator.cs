using Microsoft.Extensions.DependencyInjection;
namespace SkyCastRealtime.Service;

/// <summary>
/// 네비게이션
/// ViewModel간 필요한 데이터 교환 및 view 교체
/// </summary>
internal class Navigator
{
    /// <summary>
    /// 의존성 객체
    /// </summary>
    private readonly IServiceProvider _serviceProvider;

    /// <summary>
    /// viewmodel type 저장
    /// </summary>
    private readonly Dictionary<string, Type> _viewModelRegistry = new Dictionary<string, Type>();

    /// <summary>
    /// 생성장
    /// </summary>
    /// <param name="serviceProvider">의존성 객체</param>
    public Navigator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    /// <summary>
    /// viewmodel 등록
    /// </summary>
    /// <typeparam name="T">viewmodel type</typeparam>
    /// <param name="name">view 명칭</param>
    public void RegisterViewModel<T>(string name) where T : class
    {
        if (!_viewModelRegistry.ContainsKey(name))
        {
            _viewModelRegistry[name] = typeof(T);
        }
    }

    /// <summary>
    /// 이름으로 viewmodel 넘겨주기
    /// </summary>
    /// <param name="name">view 명칭</param>
    /// <returns>viewmodel</returns>
    /// <exception cref="InvalidOperationException">viewmodel 없을시 예외</exception>
    public object GetViewModelByName(string name)
    {
        if (_viewModelRegistry.TryGetValue(name, out var viewModelType))
        {
            return _serviceProvider.GetRequiredService(viewModelType);
        }

        throw new InvalidOperationException($"No view registered with name {name}");
    }
}
