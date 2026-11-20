using SmartHome.Devices;
using SmartHome.Services;

DeviceManager manager = new DeviceManager();

SmartFan fan = new SmartFan("1", "Вентилятор");

TemperatureSensor temperature = new TemperatureSensor("2", "Температура", 25.5);
MotionSensor motion = new MotionSensor("3", "Движение", true);

manager.AddDevice(fan);
manager.AddSensor(temperature);
manager.AddSensor(motion);

fan.TurnOn();

Console.WriteLine($"Мощность: {fan.PowerWatts} Вт");
Console.WriteLine($"За 2 часа: {fan.GetEnergyConsumption(2)} кВт·ч");
Console.WriteLine($"За 5 часов: {fan.GetEnergyConsumption(5)} кВт·ч");
Console.WriteLine($"За 10 часов: {fan.GetEnergyConsumption(10)} кВт·ч");

manager.PrintAllMeasurements();