namespace GetCurrentWeather;

public class Wind
{
    private double _speed;
    private int _deg;
    private double _gust;

    public double Speed
    {
        get => _speed;
        set => _speed = value;
    }

    public int Deg
    {
        get => _deg;
        set => _deg = value;
    }

    public double Gust
    {
        get => _gust;
        set => _gust = value;
    }
}