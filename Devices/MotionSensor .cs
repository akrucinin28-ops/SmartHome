namespace SmartHome.Devices;

public class MotionSensor : SmartSensor
{
    public bool MotionDetected { get; set; }

    public MotionSensor(string id, string name, bool motionDetected)
    : base(id, name)
    {
        MotionDetected = motionDetected;
    }

    public override string GetMeasurement()
    {
        return MotionDetected ? "Движение обнаружено" : "Движения нет";
    }
}