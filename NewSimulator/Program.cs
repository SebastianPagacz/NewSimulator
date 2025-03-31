using System.Diagnostics;

namespace NewSimulator;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting Simulator!\n");
        //Lab4a();
        //Lab4b();
        //Lab5a();
        Lab5b();
    }

    static void Lab4a()
    {
        Console.WriteLine("HUNT TEST\n");
        var o = new Orc() { Name = "Gorbag", Rage = 7 };
        o.SayHi();
        for (int i = 0; i < 10; i++)
        {
            o.Hunt();
            o.SayHi();
        }

        Console.WriteLine("\nSING TEST\n");
        var e = new Elf("Legolas", agility: 2);
        e.SayHi();
        for (int i = 0; i < 10; i++)
        {
            e.Sing();
            e.SayHi();
        }

        Console.WriteLine("\nPOWER TEST\n");
        Creature[] creatures = {
        o,
        e,
        new Orc("Morgash", 3, 8),
        new Elf("Elandor", 5, 3)
    };
        foreach (Creature creature in creatures)
        {
            Console.WriteLine($"{creature.Name,-15}: {creature.Power}");
        }
    }

    static void Lab4b()
    {
        object[] myObjects = {
        new Animals() { Description = "dogs"},
        new Birds { Description = "  eagles ", Size = 10 },
        new Elf("e", -3, 15),
        new Orc("morgash", 4, 6)
    };
        Console.WriteLine("\nMy objects:");
        foreach (var o in myObjects) Console.WriteLine(o);
        /*
            My objects:
            ANIMALS: Dogs <3>
            BIRDS: Eagles (fly+) <10>
            ELF: E## [10][0]
            ORC: Morgash [6][4]
        */
    }

    static void Lab5a()
    {
        Point p1 = new Point(1, 1);
        Point p2 = new Point(0, -1);
        Point p3 = new Point(2, 2);

        Console.WriteLine(p1.Next(Direction.Right)); // 2 , 1
        Console.WriteLine(p3.Next(Direction.Down)); // 2 , 1
        Console.WriteLine(p1.NextDiagonal(Direction.Down)); // 0 , 0
        Console.WriteLine(p3.NextDiagonal(Direction.Left)); // 1 , 3
        try
        {
            Rectangle r3 = new Rectangle(1, 1, 1, 1); // exception
            Console.WriteLine(r3);
            Rectangle r4 = new Rectangle(p1, p1); // exception
            Console.WriteLine(r4);
            Rectangle r5 = new Rectangle(p1, p3); // exception
            Console.WriteLine(r5);
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Rectangle r1 = new Rectangle(3, 3, 1, 1); // turns around
            Console.WriteLine(r1);
            Rectangle r2 = new Rectangle(1, 1, 3, 3); // g
            Console.WriteLine(r2);
            Console.WriteLine(r1.Contains(p1)); // true
            Console.WriteLine(r1.Contains(p2)); // false
            Console.WriteLine(r1.Contains(p3)); // true
        }
    }

    static void Lab5b()
    {
        try
        {
            SmallSquareMap m4 = new SmallSquareMap(21); // exception
            SmallSquareMap m1 = new SmallSquareMap(4); // exception
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        SmallSquareMap m2 = new SmallSquareMap(5);
        SmallSquareMap m3 = new SmallSquareMap(20);
        Point p1 = new Point(5, 5);
        Point p2 = new Point(20, 20);
        Point p3 = new Point(0, 0);

        Console.WriteLine(m2.Next(p1, Direction.Down)); // (5,4)
        Console.WriteLine(m2.Next(p1, Direction.Up)); // (5,5)
        Console.WriteLine(m2.NextDiagonal(p1, Direction.Up)); // (5,5)
        Console.WriteLine(m2.NextDiagonal(p1, Direction.Down)); // (4,4)
        Console.WriteLine(m3.Next(p2, Direction.Up)); // (20,20)
        Console.WriteLine(m3.NextDiagonal(p2, Direction.Down)); // (19,19)
        Console.WriteLine(m2.Next(p3, Direction.Up)); // (0,1)
        Console.WriteLine(m2.Next(p3, Direction.Right)); // (1,0)
        Console.WriteLine(m2.Next(p3, Direction.Left)); // (0,0)
        Console.WriteLine(m2.NextDiagonal(p3, Direction.Up)); // (1,1)
    }
}
