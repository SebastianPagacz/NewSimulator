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

    public abstract string SayHi();
    public void Upgrade()
    {
        if(_level < 10)
        {
            _level += 1;
        }
    }

    // Direction methods
    public string Go(Direction direction) 
    {
        return $"{Name} goes {direction.ToString().ToLower()}";
    }

    public string[] Go(Direction[] directionsArray)
    {
        List<string> result = new List<string>();
        foreach(Direction direction in directionsArray)
        {
            result.Add(Go(direction));
        }
        return result.ToArray();
    }
    public string[] Go(string moves)
    {
        List<string> result = new List<string>();
        List<Direction> movesArray = DirectionParser.Parse(moves);
        foreach(Direction direction in movesArray)
        {
            result.Add(Go(direction));
        }
        return result.ToArray();
    }

    public override string ToString() 
    {
        return $"{GetType().Name.ToUpper()} : {Info}";
    }
}
