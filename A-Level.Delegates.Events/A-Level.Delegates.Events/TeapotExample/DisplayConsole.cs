using System;

namespace A_Level.Delegates.Events.TeapotExample;

internal sealed class DisplayConsole
{
    public void Thermometer_OnDisplay(object sender, TemperatureInfoEventArgs temperatureInfo)
    {
        switch (temperatureInfo.Status)
        {
            case TemperatureStatus.Cold:
                Console.WriteLine($"Cold and to do something Celsium: {temperatureInfo.Celsium}");
                break;
            case TemperatureStatus.Warn:
                Console.WriteLine($"Warn and wait more. Celsium: {temperatureInfo.Celsium}");
                break;
            case TemperatureStatus.Hot:
                Console.WriteLine($"Hot and ready. Celsium: {temperatureInfo.Celsium}");
                break;
            default:
                break;
        }
    }
}
