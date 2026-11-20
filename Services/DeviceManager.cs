using SmartHome.Devices;

namespace SmartHome.Services;

public class DeviceManager
{
    private List<SmartDevice> devices = new();
    private List<SmartSensor> sensors = new();

    public void AddDevice(SmartDevice device)
    {
        devices.Add(device);
    }

    public void AddSensor(SmartSensor sensor)
    {
        sensors.Add(sensor);
    }

    public void ShowAll()
    {
        foreach (SmartDevice device in devices)
        {
            Console.WriteLine(device.GetStatus());
        }
    }

    public void PrintAllMeasurements()
    {
        foreach (SmartSensor sensor in sensors)
        {
            Console.WriteLine(sensor.GetMeasurement());
        }
    }
}