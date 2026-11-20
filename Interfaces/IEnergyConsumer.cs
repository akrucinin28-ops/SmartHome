namespace SmartHome.Interfaces;

public interface IEnergyConsumer
{
    double PowerWatts { get; }
    double GetEnergyConsumption(double hours);
}