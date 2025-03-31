using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSimulator;

public enum Direction
{
    [Description("up")]
    Up = 0,
    [Description("down")]
    Down = 1,
    [Description("left")]
    Left = 2,
    [Description("right")]
    Right = 3,
}
