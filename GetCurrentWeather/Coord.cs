namespace GetCurrentWeather;

public class Coord
{
    private double _lon;
    private double _lat;

    public double Lon
    {
        get => _lon;
        set => _lon = value;
    }

    public double Lat
    {
        get => _lat;
        set => _lat = value;
    }
}