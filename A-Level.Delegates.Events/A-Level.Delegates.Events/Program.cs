using System;
using A_Level.Delegates.Events.TeapotExample;

namespace A_Level.Delegates.Events;

public delegate int Operation(int x, int y);

internal class Program
{

    public static int Pow(int x, int y)
    {
        return (int)Math.Pow(x, y);
    }

    public static void Calc(Operation operation)
    {
        //...
    }

    public static void Main(string[] args)
    {
        //Calc(Pow);

        Operation operation = Pow; // new Operation(Pow)

        Calc(operation);

        Func<string, Result> func = (string name) =>
        {
            return new Result {  Name = name , Status = "NoError" };
        };

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
        };

        //new Teapot().HeatWater();
    }

    public static void FuncEx(Func<string, Result> func)
    {
        Result result = func("Vlad");
        Console.WriteLine(result);
    }
}
