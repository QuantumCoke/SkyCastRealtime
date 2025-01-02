namespace SkyCastRealtime.Model;

public class WeatherData
{
    /// <summary>
    /// 응답
    /// </summary>
    public Response response { get; set; }
}


public class Body
{
    /// <summary>
    /// 응답자료형식
    /// </summary>
    public string dataType { get; set; }

    /// <summary>
    /// 정보들
    /// </summary>
    public Items items { get; set; }

    /// <summary>
    /// 페이지 번호
    /// </summary>
    public int pageNo { get; set; }

    /// <summary>
    /// 한 페이지 결과 수
    /// </summary>
    public int numOfRows { get; set; }

    /// <summary>
    /// 데이터 총 개수
    /// </summary>
    public int totalCount { get; set; }
}

public class Header
{
    /// <summary>
    /// 응답 메시지 코드
    /// </summary>
    public string resultCode { get; set; }

    /// <summary>
    /// 응답 메시지 내용
    /// </summary>
    public string resultMsg { get; set; }
}

public class Item
{
    /// <summary>
    /// 예보구역코드
    /// </summary>
    public string regId { get; set; }

    /// <summary>
    /// 4일 후 오전 강 수 확률
    /// </summary>
    public int rnSt4Am { get; set; }

    /// <summary>
    /// 4일 후 오후 강 수 확률
    /// </summary>
    public int rnSt4Pm { get; set; }

    /// <summary>
    /// 5일 후 오전 강 수 확률
    /// </summary>
    public int rnSt5Am { get; set; }

    /// <summary>
    /// 5일 후 오후 강 수 확률
    /// </summary>
    public int rnSt5Pm { get; set; }

    /// <summary>
    /// 4일 후 오전 강 수 확률
    /// </summary>
    public int rnSt6Am { get; set; }

    /// <summary>
    /// 6일 후 오후 강 수 확률
    /// </summary>
    public int rnSt6Pm { get; set; }

    /// <summary>
    /// 7일 후 오전 강 수 확률
    /// </summary>
    public int rnSt7Am { get; set; }

    /// <summary>
    /// 7일 후 오후 강 수 확률
    /// </summary>
    public int rnSt7Pm { get; set; }

    /// <summary>
    /// 8일 후 오전 강 수 확률
    /// </summary>
    public int rnSt8 { get; set; }

    /// <summary>
    /// 9일 후 오전 강 수 확률
    /// </summary>
    public int rnSt9 { get; set; }

    /// <summary>
    /// 10일 후 오전 강 수 확률
    /// </summary>
    public int rnSt10 { get; set; }

    /// <summary>
    /// 4일 후 오전 날씨예보
    /// </summary>
    public string wf4Am { get; set; }

    /// <summary>
    /// 4일 후 오후 날씨예보
    /// </summary>
    public string wf4Pm { get; set; }

    /// <summary>
    /// 5일 후 오전 날씨예보
    /// </summary>
    public string wf5Am { get; set; }

    /// <summary>
    /// 5일 후 오후 날씨예보
    /// </summary>
    public string wf5Pm { get; set; }

    /// <summary>
    /// 6일 후 오전 날씨예보
    /// </summary>
    public string wf6Am { get; set; }

    /// <summary>
    /// 6일 후 오후 날씨예보
    /// </summary>
    public string wf6Pm { get; set; }

    /// <summary>
    /// 7일 후 오전 날씨예보
    /// </summary>
    public string wf7Am { get; set; }

    /// <summary>
    /// 7일 후 오후 날씨예보
    /// </summary>
    public string wf7Pm { get; set; }

    /// <summary>
    /// 8일 후 날씨예보
    /// </summary>
    public string wf8 { get; set; }

    /// <summary>
    /// 9일 후 날씨예보
    /// </summary>
    public string wf9 { get; set; }

    /// <summary>
    /// 10일 후 날씨예보
    /// </summary>
    public string wf10 { get; set; }
}

public class Items
{
    /// <summary>
    /// 정보
    /// </summary>
    public List<Item> item { get; set; }
}

public class Response
{
    /// <summary>
    /// 헤더
    /// </summary>
    public Header header { get; set; }

    /// <summary>
    /// 바디
    /// </summary>
    public Body body { get; set; }
}