using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;

namespace A_Level.Delegates.Events;

public delegate int Operation(int x, int y);

public class Subscribes
{
    public static int Pow(int x, int y)
    {
        Console.WriteLine("Pow function.");
        return (int)Math.Pow(x, y);
    }

    public int Multiply(int x, int y)
    {
        Console.WriteLine("Multiply function.");
        return x * y;
    }
}

internal class Program
{
    public static void Calc(Operation operation)
    {
        int calculation = operation(2, 3);
        Console.WriteLine(calculation);
        //...
    }

    public static int Map(int x)
    {
        return x * 2;
    }

    public static void Subscribe(object o, EventArgs ev)
    {
        Console.WriteLine("PrinterStarted is executed lambda func.");
    }

    public static void Main(string[] args)
    {
        var printer = new Printer();

        printer.PrinterStarted += (object o, EventArgs ev) =>
        {
            Console.WriteLine("PrinterStarted is executed lambda func.");
        };

        var sub = (object o, EventArgs ev) =>
        {
            Console.WriteLine("PrinterStarted is executed lambda func.");
        };
        printer.DelegatePrinterStarted += Subscribe;

        printer.Start();

        ClosureExample.MainClosureExample();

        var subs = new Subscribes();
        Operation operation = Subscribes.Pow;
        operation += subs.Multiply;

        int result1 = operation(10, 20);
        int result2 = operation.Invoke(10, 20);

        Operation operationAnonymous1 = delegate(int x, int y)
        {
            Console.WriteLine("Pow function.");
            return (int)Math.Pow(x, y);
        };

        Operation operationAnonymous2 = int (int x, int y) => (int)Math.Pow(x, y);
        operationAnonymous2(10, 20);

        //Calc(Pow);
        //Calc(Multiply);

        Func<string, Result> func = (string name) => new Result {  Name = name , Status = "NoError" };

        Result res = func("EverythingGood");
        
        FuncEx(func);

        //ClosureExample.MainClosureExample();

        //ClosureExample.WrongExample();

        //ClosureExample.GoodExample();

        //Delegates.CustomeDelegateExample();
        //Delegates.MulticastCustomeDelegateExample();

        //ClosureExample.MainClosureExample();
        //Console.WriteLine("Delegates Example.");
        //Delegates.MulticastCustomeDelegateExample();

        //Console.WriteLine("Console Example.");
        //Console.WriteLine("Teapot Example.");

        Console.CancelKeyPress += (object o, ConsoleCancelEventArgs ev) =>
        {
            Console.WriteLine("Cancel Key Pressed 123");
            Environment.Exit(0);
        };

        //new Teapot().HeatWater();
    }

    public static void FuncEx(Func<string, Result> func)
    {
        Result result = func("Vlad");
        Console.WriteLine(result);
    }
}
