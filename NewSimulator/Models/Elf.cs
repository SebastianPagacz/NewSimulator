using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSimulator;

class Elf : Creature
{
    private int _agility = 1;
    private int _singCounter = 0;

    public int Agility
    {
        get => _agility;
        init
        {
            _agility = Validator.Limiter(value, 0, 10);
        }
    }
    public override int Power
    {
        get => 7 * Level + 3 * Agility;
    }

    public override string Info { get => $"{Name} [{Level}][{Agility}]"; }
    public void Sing()
    {
        Console.WriteLine($"{Name} is singing.");
        _singCounter++;
        if (_singCounter % 3 == 0)
        {
            if (_agility < 10)
            {
                ++_agility;
            }
        }
    }

    public Elf(string name, int agility, int level = 1) : base(name, level)
    {
        Agility = agility;
    }
    public Elf(string name) : base(name)
    {
        Name = name;
    }
    public Elf()
    {

    }

    public override void SayHi()
    {
        Console.WriteLine($"Hi, I'm {Name}, my level is {Level}, my agility is {Agility}.");
    }
}
