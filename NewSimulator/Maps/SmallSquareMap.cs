using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSimulator;

public class SmallSquareMap : SmallMap
{

    public SmallSquareMap(int sizeX, int sizeY) : base (sizeX, sizeY)
    {

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
