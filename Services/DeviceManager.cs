using SmartHome.Devices;

namespace SmartHome.Services;

public class DeviceManager
{
    private List<SmartDevice> devices = new();

    public void AddDevice(SmartDevice device)
    {
        devices.Add(device);
    }

    public void ShowAll()
    {
        foreach (SmartDevice device in devices)
        {
            Console.WriteLine(device.GetStatus());
        }
    }
}