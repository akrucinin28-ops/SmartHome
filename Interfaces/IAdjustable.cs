namespace SmartHome.Interfaces;

public interface IAdjustable
{
    int Level { get; }
    void SetLevel(int level);
}