using System;
using System.Collections.Generic;

namespace A_Level.Delegates.Events;

public static class Test
{
    public static string Name { get; set; } = "12313";
}

internal static class ClosureExample
{
    public static void MainClosureExample()
    {
        var name = "Den";

        Action<int, int> action = (int x, int y) =>
        {
            string hello = "hello";
            Console.WriteLine("1 MainClosureExample -> " + $" Name: {Test.Name} {hello} {x} {y}");
            Console.WriteLine("2 MainClosureExample -> " + $" Name: {name} {x} {y}");
            Console.WriteLine("3 MainClosureExample -> " + $" Name: {name} {x} {y}");
        };

        action(10, 20);

        name = "John";
        Test.Name = "999999";

        action(30, 40);

        var screen = new ClosureUnderTheScreen();

        screen.name = "Den";
        screen.ClosureMethod(10, 20);

        screen.name = "John";
        screen.ClosureMethod(30, 40);
    }

    public class ClosureUnderTheScreen
    {
        public string name;

        public void ClosureMethod(int x, int y)
        {
            Console.WriteLine("3 MainClosureExample -> " + $" Name: {name} {x} {y}");
            Console.WriteLine("1 MainClosureExample -> " + $" Name: {name} {x} {y}");
            Console.WriteLine("2 MainClosureExample -> " + $" Name: {name} {x} {y}");
        }
    }

    public static void WrongExample()
    {
        var funcs = new List<Func<int>>();

        for (int i = 0; i < 3; i++)
        {
            funcs.Add(() => i);
        }

        foreach (Func<int> func in funcs)
        {
            Console.WriteLine(func());
        }
    }

    public static void GoodExample()
    {
        var funcs = new List<Func<int>>();

        for (int i = 0; i < 3; i++)
        {
            int j = i;
            funcs.Add(() => j);
        }

        foreach (Func<int> func in funcs)
        {
            Console.WriteLine(func());
        }
    }
}
