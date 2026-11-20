namespace SmartHome.Devices;


public abstract class SmartSensor
{
    public string Id { get; }
    public string Name { get; set; }

    protected SmartSensor(string id, string name)
    {
        Id = id;
        Name = name;
    }

    public abstract string GetMeasurement();

    public virtual string GetStatus()
    {
        return $"Датчик {Name}: {GetMeasurement()}";
    }
}