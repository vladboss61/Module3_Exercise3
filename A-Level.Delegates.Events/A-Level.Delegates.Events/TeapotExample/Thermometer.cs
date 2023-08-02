using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Level.Delegates.Events.TeapotExample;

public enum TemperatureStatus { Cold, Warn, Hot };

public delegate void TemperatureHandler(TemperatureInfoEventArgs info);


public class TemperatureInfoEventArgs : EventArgs
{
    public TemperatureStatus Status { get; set; }

    public int Celsium { get; set; }
}


internal sealed class Thermometer
{
    private const int MaxCelsium = 72;
    private int _currentCelsium = 0;

    public event EventHandler<TemperatureInfoEventArgs> ListCelsiumHandler;

    private void OnHandler(TemperatureStatus status)
    {
        if (ListCelsiumHandler is not null)
        {
            ListCelsiumHandler(this, new TemperatureInfoEventArgs { Status = status, Celsium = _currentCelsium });
        }
    }

    public void HeatThermometer(int power)
    {
        _currentCelsium = _currentCelsium + Themp(power);

        if (_currentCelsium >= MaxCelsium)
        {
            OnHandler(TemperatureStatus.Hot);
            return;
        }

        if (_currentCelsium > 55 && _currentCelsium < MaxCelsium)
        {
            OnHandler(TemperatureStatus.Warn);
            return;
        }

        OnHandler(TemperatureStatus.Cold);
    }

    private int Themp(int power)
    {
        if (power == 0)
        {
            return 0;
        }
        else if (power > 0 && power < 25)
        {
            return 7;
        }

        return 30;
    }
}
