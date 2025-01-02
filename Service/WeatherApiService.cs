using System.ComponentModel.DataAnnotations;
using System.Net.Http;

namespace SkyCastRealtime.Service;

internal class WeatherApiService
{
    private readonly HttpClient _httpClient;

    internal WeatherApiService()
    {
        _httpClient = new HttpClient();
    }

/// <summary>
/// 
/// </summary>
/// <param name="serviceKey"></param>
/// <param name="pageNo"></param>
/// <param name="numOfRows"></param>
/// <param name="dataType"></param>
/// <param name="regId"></param>
/// <param name="tmFc"></param>
/// <returns></returns>
/// <exception cref="Exception"></exception>
    internal async Task<string> GetRegionDataDataAsync(string serviceKey, string pageNo, string numOfRows, string dataType, string regId, string tmFc)
    {
        string url = $"https://apis.data.go.kr/1360000/MidFcstInfoService/getMidLandFcst" +
                     $"?serviceKey={serviceKey}&pageNo={pageNo}&numOfRows={numOfRows}&dataType={dataType}&regId={regId}&tmFc={tmFc}";

        var response = await _httpClient.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadAsStringAsync();
        }

        throw new Exception($"지역 데이터 요청 API 호출 실패: {response.StatusCode}");
    }
}
