using System;
using System.Globalization;

namespace A_Level.Delegates.Events;

internal delegate void DelegateFunction(string funcName, int value);

internal static class Delegates
{
    public static void CustomeDelegateExample()
    {
        Action<string, int> delegateFunction = Display; // new Action<string, int>(Display);

        string name = nameof(CustomeDelegateExample);
        
        delegateFunction(name, 10);

        delegateFunction.Invoke(name, 20);
    }

    public static void FuncEx(DelegateFunction function)
    {
        function(nameof(FuncEx), 9999);
    }

    public static void MulticastCustomeDelegateExample()
    {
        string hello = "Hello";

        DelegateFunction delegateFunction = Display;
        delegateFunction += DisplayWithStars;

        delegateFunction(nameof(MulticastCustomeDelegateExample), 10);

        delegateFunction -= DisplayWithStars;

        delegateFunction.Invoke(nameof(MulticastCustomeDelegateExample), 99);

        delegateFunction += DisplayWithStars;
        delegateFunction += DisplayWithStars;

        Delegate[] delegates = delegateFunction.GetInvocationList();

        foreach (var @delegate in delegates)
        {
            Console.WriteLine("Loop with dynamically invoke " + " "+ @delegate.Method);

            Action act = () => @delegate.DynamicInvoke(nameof(MulticastCustomeDelegateExample), 99);

            ConsoleColors.Switch(ConsoleColor.Red, act);
        }
    }

    private static void Display(string funcName, int value)
    {
        Console.WriteLine($"{funcName} -> Value: {value}.");
    }

    private static void DisplayWithStars(string funcName, int value)
    {
        Console.WriteLine($"{funcName}-> *****Value: {value}.*****");
    }
}
