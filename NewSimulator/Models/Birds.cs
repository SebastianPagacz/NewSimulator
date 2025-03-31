using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSimulator;

public class Birds : Animals
{
    public bool CanFly { get; set; } = true;

    public string FlyParser(bool canFly)
    {
        if (canFly)
        {
            return "fly+";
        }
        return "fly-";
    }

    public override string Info => $"{Description} ({FlyParser(CanFly)}) <{Size}>";
}
