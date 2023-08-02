using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Level.Delegates.Events;

internal static class ConsoleColors
{
    public static void Switch(ConsoleColor consoleColor, Action perform)
    {
        var current = Console.ForegroundColor;
        Console.ForegroundColor = consoleColor;

        perform();

        Console.ForegroundColor = current;
    }
}
