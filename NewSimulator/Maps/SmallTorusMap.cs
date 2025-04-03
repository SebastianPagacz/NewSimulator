using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSimulator;

public class SmallTorusMap : SmallMap
{

    public SmallTorusMap(int sizeX, int sizeY) : base(sizeX, sizeY)
    {

    }

    public override Point Next(Point p, Direction d)
    {
        if (!Exist(p.Next(d))) 
        {
            switch (d)
            {
                case (Direction.Up):
                    return new Point(p.X, (p.Y + 1) % SizeY);
                case (Direction.Down):
                    return new Point(p.X, (p.Y - 1 + SizeX) % SizeY);
                case (Direction.Left):
                    return new Point((p.X - 1 + SizeX) % SizeX, p.Y);
                case (Direction.Right):
                    return new Point((p.X + 1) % SizeX, p.Y);
                default:
                    return p;
            }
        }
        return p.Next(d);
    }
    // Zobaczymy czy dziala
    public override Point NextDiagonal(Point p, Direction d)
    {
        if (!Exist(p.NextDiagonal(d)))
        {
            switch (d)
            {
                case (Direction.Up):
                    return new Point((p.X + 1) % SizeX, (p.Y + 1) % SizeY);
                case (Direction.Down):
                    return new Point((p.X - 1 + SizeX) % SizeX, (p.Y - 1 + SizeY) % SizeY);
                case (Direction.Left):
                    return new Point((p.X - 1 + SizeX) % SizeX, (p.Y + 1) % SizeY);
                case (Direction.Right):
                    return new Point((p.X + 1) % SizeX, (p.Y - 1 + SizeY) % SizeY);
                default:
                    return p;
            }
        }
        return p.NextDiagonal(d);
    }
}
