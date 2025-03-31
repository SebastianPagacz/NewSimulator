using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSimulator;

class Orc : Creature
{
    private int _rage = 1;
    private int _huntCounter;
    public int Rage 
    { 
        get => _rage;
        init
        {
            _rage = value;
            if (_rage < 0)
                _rage = 1;
            if (_rage > 11)
                _rage = 10;
        }
    }
    public override int Power 
    {
        get => 8*Level + 2*Rage;
    }

    public override string Info { get => $"{Name} [{Level}][{Rage}]"; }
    public void Hunt()
    {
        Console.WriteLine($"{Name} is hunting.");
        _huntCounter++;
        if (_huntCounter % 2==0)
        {
            if (_rage < 10)
            {
                _rage++;
            }
        }
    }

    public Orc(string name, int rage, int level = 1) : base(name, level)
    {
        Rage = rage;
    }
    public Orc(string name) : base(name)
    {
        Name = name;
    }
    public Orc()
    {

    }

    public override void SayHi()
    {
        Console.WriteLine($"Hi, I'm {Name}, my level is {Level}, my rage is {Rage}.");
    }
}
