using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSimulator;

public class Simulation
{
    private int currentTurn = 0;
    private List<Direction> parsedMoves => DirectionParser.Parse(Moves);
    /// <summary>
    /// Simulation's map.
    /// </summary>
    public Map Map { get; }

    /// <summary>
    /// Creatures moving on the map.
    /// </summary>
    public List<Creature> Creatures { get; }

    /// <summary>
    /// Starting positions of creatures.
    /// </summary>
    public List<Point> Positions { get; }

    /// <summary>
    /// Cyclic list of creatures moves. 
    /// Bad moves are ignored - use DirectionParser.
    /// First move is for first creature, second for second and so on.
    /// When all creatures make moves, 
    /// next move is again for first creature and so on.
    /// </summary>
    public string Moves { get; }

    /// <summary>
    /// Has all moves been done?
    /// </summary>
    public bool Finished = false;

    /// <summary>
    /// Creature which will be moving current turn.
    /// </summary>
    public Creature CurrentCreature 
    {
        get 
        {
            return Creatures[currentTurn % Creatures.Count];
        }
    }

    /// <summary>
    /// Lowercase name of direction which will be used in current turn.
    /// </summary>
    public string CurrentMoveName 
    {
        get 
        {
            return !Finished ? $"{parsedMoves[currentTurn].ToString().ToLower()}" : "Simulation is done"; 
        }
    }

    /// <summary>
    /// Simulation constructor.
    /// Throw errors:
    /// if creatures' list is empty,
    /// if number of creatures differs from 
    /// number of starting positions.
    /// </summary>
    public Simulation(Map map, List<Creature> creatures,
        List<Point> positions, string moves)
    {
        if(!creatures.Any())
        {
            throw new ArgumentException("There must be at least one creature for the simulation");
        }

        if (creatures.Count != positions.Count)
        {
            throw new ArgumentException("Not enough starting positions for all reatures");
        }

        Map = map;
        Creatures = creatures;
        Positions = positions;
        Moves = moves;
    }

    /// <summary>
    /// Makes one move of current creature in current direction.
    /// Throw error if simulation is finished.
    /// </summary>
    public void Turn() 
    {
        if (Finished)
        {
            throw new InvalidOperationException("Simulation is finished");
        }

        CurrentCreature.Go(parsedMoves[currentTurn]);
        currentTurn++;

        if (currentTurn == parsedMoves.Count)
        {
            Finished = true;
        }
    }
}
