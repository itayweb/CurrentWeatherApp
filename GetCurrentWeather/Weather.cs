namespace GetCurrentWeather;

public class Weather
{
    private int _id;
    private string _main;
    private string _description;
    private string _icon;

    public string Icon
    {
        get => _icon;
        set => _icon = value;
    }

    public string Description
    {
        get => _description;
        set => _description = value;
    }

    public string Main
    {
        get => _main;
        set => _main = value;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }
}