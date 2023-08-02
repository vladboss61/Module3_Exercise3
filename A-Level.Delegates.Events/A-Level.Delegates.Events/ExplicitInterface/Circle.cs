using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Level.Delegates.Events.ExplicitInterface;


public class Circle : IShape, IAnotherShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    // Explicit implementation of IShape's Draw method
    void IShape.Draw() // private by default
    {
        Console.WriteLine($"Drawing a circle with radius {_radius} using IShape interface");
    }

    // Explicit implementation of IAnotherShape's Draw method
    void IAnotherShape.Draw() // private by default
    {
        Console.WriteLine($"Drawing a circle with radius {_radius} using IAnotherShape interface");
    }
}
