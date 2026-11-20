using SmartHome.Devices;
using SmartHome.Services;

DeviceManager manager = new DeviceManager();

SmartFan fan = new SmartFan("1", "Вентилятор");
manager.AddDevice(fan);

fan.SetSchedule(
    new TimeSpan(8, 0, 0),
    new TimeSpan(22, 0, 0)
);

fan.CheckSchedule(new DateTime(2026, 1, 1, 10, 0, 0));
manager.ShowAll();

fan.CheckSchedule(new DateTime(2026, 1, 1, 23, 0, 0));
manager.ShowAll();
