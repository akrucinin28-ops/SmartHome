namespace SmartHome.Devices;

public abstract class SmartDevice
{
    public string Id { get; }
    public string Name { get; set; }
    public bool IsOn { get; protected set; }

    protected SmartDevice(string id, string name)
    {
        Id = id;
        Name = name;
    }

    public virtual void TurnOn()
    {
        IsOn = true;
        Console.WriteLine($"{Name} включено");
    }

    public virtual void TurnOff()
    {
        IsOn = false;
        Console.WriteLine($"{Name} выключено");
    }

    public abstract string GetStatus();
}