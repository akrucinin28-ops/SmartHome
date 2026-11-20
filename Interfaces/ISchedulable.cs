namespace SmartHome.Interfaces;

public interface ISchedulable
{
    void SetSchedule(TimeSpan onTime, TimeSpan offTime);
    void CheckSchedule(DateTime currentTime);
}