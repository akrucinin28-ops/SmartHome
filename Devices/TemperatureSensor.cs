namespace SmartHome.Devices;

public class TemperatureSensor : SmartSensor
{
    public double Temperature { get; set; }

    public TemperatureSensor(string id, string name, double temperature)
    : base(id, name)
    {
        Temperature = temperature;
    }

    public override string GetMeasurement()
    {
        return $"{Temperature} °C";
    }
}