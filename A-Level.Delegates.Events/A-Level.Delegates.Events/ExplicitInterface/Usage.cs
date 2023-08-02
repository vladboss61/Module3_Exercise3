using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Level.Delegates.Events.ExplicitInterface;

public static class Usage
{
    public static void UsageClasses()
    {
        var circle = new Circle(5.0);

        //circle.Draw(); // Always private.

        IShape shape = new Circle(5.0);
        IAnotherShape anotherShape = new Circle(7.0);

        // Calling explicit interface implementations
        shape.Draw();         // Calls IShape's Draw
        anotherShape.Draw();  // Calls IAnotherShape's Draw

        var square = new Square();
        square.Draw();
    }
}
