using SmartHome.Interfaces;

namespace SmartHome.Devices;

public class SmartFan : SmartDevice, IAdjustable, ISchedulable
{
    public int Speed { get; private set; } = 0;

    public SmartFan(string id, string name)
        : base(id, name)
    {
    }

    public int Level => Speed;

    public void SetLevel(int level)
    {
        if (level < 0 || level > 5)
            throw new ArgumentOutOfRangeException(
                nameof(level), "Скорость от 0 до 5");

        Speed = level;
    }

    public override string GetStatus()
    {
        return $"Вентилятор [{Name}]: " +
               $"{(IsOn ? "вкл" : "выкл")}, " +
               $"скорость {Speed}";
    }
    private TimeSpan onTime;
    private TimeSpan offTime;

    public void SetSchedule(TimeSpan onTime, TimeSpan offTime)
    {
        this.onTime = onTime;
        this.offTime = offTime;
    }

    public void CheckSchedule(DateTime currentTime)
    {
        TimeSpan time = currentTime.TimeOfDay;

        if (time >= onTime && time < offTime)
        {
            TurnOn();
        }
        else
        {
            TurnOff();
        }
    }
}

