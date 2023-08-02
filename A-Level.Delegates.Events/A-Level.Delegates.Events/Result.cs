using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Level.Delegates.Events;

public class Result
{
    public string Name { get; set; }

    public string Status { get; set; }

    public override string ToString()
    {
        return $"{Name} --- {Status}";
    }
}
