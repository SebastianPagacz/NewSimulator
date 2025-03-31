using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NewSimulator;

public abstract class Creature
{
    private int _level;
    private string _name = string.Empty;
    public int Level
    {
        get => _level;
        init
        {
            _level = Validator.Limiter(value, 1, 10);
        }
    }
    public string Name
    {
        get => _name;
        init 
        {
            _name = Validator.StringValidator(value, 3, 15, '#');
        }
    }
    public abstract string Info { get; }

    public abstract int Power { get; }

    public Creature(string name, int level)
    {
        Level = level;
        Name = name;
    }
    public Creature(string name)
    {
        Name = name;
    }
    public Creature()
    {

    }

    public abstract void SayHi();
    public void Upgrade()
    {
        if(_level < 10)
        {
            _level += 1;
        }
    }

    // Direction methods
    public void Go(Direction direction) 
    {
        Console.WriteLine($"{Name} goes {direction.ToString().ToLower()}");
    }

    public void Go(Direction[] directionsArray)
    {
        foreach(Direction direction in directionsArray)
        {
            Go(direction);
        }
    }
    public void Go(string moves)
    {
        Direction[] movesArray = DirectionParser.Parse(moves);
        foreach(Direction direction in movesArray)
        {
            Go(direction);
        }
    }

    public override string ToString() 
    {
        return $"{GetType().Name.ToUpper()} : {Info} ";
    }
}
