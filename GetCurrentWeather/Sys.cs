namespace GetCurrentWeather;

public class Sys
{
    private int _type;
    private int _id;
    private string _country;
    private int _sunrise;
    private int _sunset;

    public int Type
    {
        get => _type;
        set => _type = value;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Country
    {
        get => _country;
        set => _country = value;
    }

    public int Sunrise
    {
        get => _sunrise;
        set => _sunrise = value;
    }

    public int Sunset
    {
        get => _sunset;
        set => _sunset = value;
    }
}