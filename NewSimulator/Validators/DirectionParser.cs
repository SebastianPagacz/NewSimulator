using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSimulator;

public static class DirectionParser
{
    public static List<Direction> Parse(string input)
    {
        List<Direction> result = new List<Direction>();
        foreach (char c in input.ToLower())
        {
            {
                switch (c)
                {
                    case 'u':
                        result.Add(Direction.Up);
                        break;
                    case 'l':
                        result.Add(Direction.Left);
                        break;
                    case 'r':
                        result.Add(Direction.Right);
                        break;
                    case 'd':
                        result.Add(Direction.Down);
                        break;
                    default:
                        continue;
                }
            }
        }

        return result;
    }
}
