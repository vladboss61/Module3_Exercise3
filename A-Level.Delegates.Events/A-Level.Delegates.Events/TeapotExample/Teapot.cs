using System.Threading;

namespace A_Level.Delegates.Events.TeapotExample;

internal sealed class Teapot
{
    private bool _isActive;
    private readonly Thermometer _thermometer;

    public Teapot()
    {
        _thermometer = new Thermometer();
        var displayer = new DisplayConsole();

        _thermometer.ListCelsiumHandler += Thermometer_OnDefender;             // Defender
        _thermometer.ListCelsiumHandler += displayer.Thermometer_OnDisplay;   //  Display
    }

    public void HeatWater()
    {
        _isActive = true;
        while (_isActive)
        {
            _thermometer.HeatThermometer(10);
            Thread.Sleep(500);
        }
    }

    private void Thermometer_OnDefender(object sender, TemperatureInfoEventArgs temperatureInfo)
    {
        if (temperatureInfo.Status == TemperatureStatus.Hot)
        {
            _isActive = false;
        }
    }
}
