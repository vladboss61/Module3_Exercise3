using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Level.Delegates.Events.ExplicitInterface;

public sealed class Square : IShape
{
    public void Draw() // Implicit interface implementation.
    {
        Console.WriteLine("Drawing a square");
    }
}
