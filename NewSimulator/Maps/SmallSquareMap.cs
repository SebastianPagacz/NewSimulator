using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSimulator;

public class SmallSquareMap : Map
{
    public Point LeftBottomCorner;
    public Point RightTopCorner;

    public SmallSquareMap(int size)
    {
        if (size < 5 || size > 20)
            throw new ArgumentOutOfRangeException("The size of the map is to small");

        LeftBottomCorner = new Point(0, 0);
        RightTopCorner = new Point(size, size);
    }
    
    public override bool Exist(Point p)
    {
         if (p.X < LeftBottomCorner.X || p.X > RightTopCorner.X) return false;
         if (p.Y < LeftBottomCorner.Y || p.Y > RightTopCorner.Y) return false;
         else return true;
    }

    public override Point Next(Point p, Direction d)
    {
        if (Exist(p.Next(d)))
            return p.Next(d);
        else
            return p;
    }

    public override Point NextDiagonal(Point p, Direction d)
    {
        if(Exist(p.NextDiagonal(d)))
            return p.NextDiagonal(d);
        else return p;
    }
}
