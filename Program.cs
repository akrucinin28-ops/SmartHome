using SmartHome.Devices;

SmartFan fan = new SmartFan("1", "Вентилятор");

fan.TurnOn();

Console.WriteLine($"Мощность: {fan.PowerWatts} Вт");

Console.WriteLine($"За 2 часа: {fan.GetEnergyConsumption(2)} кВт·ч");

Console.WriteLine($"За 5 часов: {fan.GetEnergyConsumption(5)} кВт·ч");

Console.WriteLine($"За 10 часов: {fan.GetEnergyConsumption(10)} кВт·ч");