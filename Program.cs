using SmartHome.Devices;
using SmartHome.Services;

DeviceManager manager = new DeviceManager();

SmartFan fan = new SmartFan("1", "Вентилятор");

manager.AddDevice(fan);

fan.TurnOn();
fan.SetLevel(3);

manager.ShowAll();