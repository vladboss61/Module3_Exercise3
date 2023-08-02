using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Level.Delegates.Events;


public sealed class PrinterEventArgs : EventArgs
{
    public string ScanInfo { get; set; }
}

internal class Printer
{
    public EventHandler<EventArgs> DelegatePrinterStarted;

    public event EventHandler<EventArgs> PrinterStarted;

    public event EventHandler<EventArgs> PrinterStoped;

    public event EventHandler<PrinterEventArgs> OnPrint;

    public void Start()
    {
        PrinterStarted?.Invoke(this, new EventArgs());
    }

    public void Stop()
    {
        PrinterStoped?.Invoke(this, new EventArgs());
    }

    public void Print()
    {
        OnPrint?.Invoke(this, new PrinterEventArgs());
    }
}
