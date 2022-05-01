namespace GetCurrentWeather;

public class Main
{
    private double _temp;
    private double _feelsLike;
    private double _tempMin;
    private double _tempMax;
    private int _pressure;
    private int _humidity;

    public double Temp
    {
        get => _temp;
        set => _temp = value;
    }

    public double FeelsLike
    {
        get => _feelsLike;
        set => _feelsLike = value;
    }

    public double TempMin
    {
        get => _tempMin;
        set => _tempMin = value;
    }

    public double TempMax
    {
        get => _tempMax;
        set => _tempMax = value;
    }

    public int Pressure
    {
        get => _pressure;
        set => _pressure = value;
    }

    public int Humidity
    {
        get => _humidity;
        set => _humidity = value;
    }
}