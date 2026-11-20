using SmartHome.Devices;
using SmartHome.Services;

DeviceManager manager = new DeviceManager();

TemperatureSensor temperature = new TemperatureSensor("1", "Температура", 25.5);
MotionSensor motion = new MotionSensor("2", "Движение", true);

manager.AddSensor(temperature);
manager.AddSensor(motion);

manager.PrintAllMeasurements();