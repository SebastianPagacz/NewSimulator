using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSimulator;

public abstract class SmallMap : Map
{
    public int SizeX { get; init; }
    public int SizeY { get; init; }

    public SmallMap(int sizeX, int sizeY)
    {
        if (sizeX < 5 || sizeY < 5 || sizeX > 20 || sizeY > 20)
            throw new ArgumentOutOfRangeException("The size of the map is to small");

        SizeX = sizeX;
        SizeY = sizeY;
    }
    public override bool Exist(Point p)
    {
        if (p.X <= 0 || p.X > SizeX - 1) return false;
        if (p.Y <= 0 || p.Y > SizeY - 1) return false;
        else return true;
    }

    public override Point Next(Point p, Direction d)
    {
        throw new NotImplementedException();
    }

    public override Point NextDiagonal(Point p, Direction d)
    {
        throw new NotImplementedException();
    }
}
