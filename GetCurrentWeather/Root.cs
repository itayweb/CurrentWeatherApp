namespace GetCurrentWeather;

public class Root
{
    private Coord _coord;
    private Weather[] _weather;
    private string _base;
    private Main _main;
    private int _visibility;
    private Wind _wind;
    private Clouds _clouds;
    private int _dt;
    private Sys _sys;
    private int _timezone;
    private int _id;
    private string _name;
    private int _cod;

    public Coord Coord
    {
        get => _coord;
        set => _coord = value;
    }

    public Weather[] Weather
    {
        get => _weather;
        set => _weather = value;
    }

    public string Base
    {
        get => _base;
        set => _base = value;
    }

    public Main Main
    {
        get => _main;
        set => _main = value;
    }

    public int Visibility
    {
        get => _visibility;
        set => _visibility = value;
    }

    public Wind Wind
    {
        get => _wind;
        set => _wind = value;
    }
}