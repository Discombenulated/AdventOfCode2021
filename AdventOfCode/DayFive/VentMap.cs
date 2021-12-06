using System;
using System.Drawing;

namespace AdventOfCode.DayFive
{
    public class VentMap
    {
        private List<Vent> Vents;

        private int[,] Map;

        public VentMap(string[] input, bool includeDiagonals = true)
        {
            this.Vents = CreateVents(input, includeDiagonals);
            this.Map = CreateMap(this.Vents);
            PopulateMap();
            PrintMap();
        }

        private List<Vent> CreateVents(string[] input, bool includeDiagonals)
        {
            return input.Select(line => new Vent(line)).Where(v => includeDiagonals || v.Start.X == v.End.X || v.Start.Y == v.End.Y).ToList();
        }

        private int[,] CreateMap(List<Vent> vents)
        {
            var maxX = vents.Max(v => Math.Max(v.Start.X, v.End.X)) + 1;
            var maxY = vents.Max(v => Math.Max(v.Start.Y, v.End.Y)) + 1;
            var map = new int[maxX, maxY];
            for (int x = 0; x < maxX; x++)
            {
                for (int y = 0; y < maxY; y++)
                {
                    map[x, y] = 0;
                }
            }
            return map;
        }

        private void PopulateMap()
        {
            foreach (var vent in Vents)
            {
                if (vent.Start.X == vent.End.X)
                {
                    Console.WriteLine($"Vertial {vent}");

                    //Vertical line
                    for (int y = vent.Start.Y; y != vent.End.Y;)
                    {
                        Map[vent.Start.X, y]++;
                        if (vent.Start.Y < vent.End.Y) y++;
                        else y--;
                    }

                }
                else if (vent.Start.Y == vent.End.Y)
                {
                    Console.WriteLine($"Horizontal {vent}");
                    //Horizontal line
                    for (int x = vent.Start.X; x != vent.End.X;)
                    {
                        Map[x, vent.Start.Y]++;
                        if (vent.Start.X < vent.End.X) x++;
                        else x--;
                    }
                }
                else
                {
                    Console.WriteLine($"Diagonal {vent}");
                    var x = vent.Start.X;
                    var y = vent.Start.Y;
                    while (x != vent.End.X || y != vent.End.Y)
                    {
                        Map[x, y]++;
                        if (vent.Start.X < vent.End.X) x++;
                        else x--;

                        if (vent.Start.Y < vent.End.Y) y++;
                        else y--;
                    }
                }
                Map[vent.End.X, vent.End.Y]++;
            }
        }

        private bool Between(int num, int lower, int upper)
        {
            if (lower > upper)
            {
                var temp = lower;
                lower = upper;
                upper = temp;
            }
            return lower <= num && num <= upper;
        }

        private void PrintMap()
        {
            Console.Write(Environment.NewLine);
            for (int y = 0; y < Map.GetLength(1); y++)
            {
                for (int x = 0; x < Map.GetLength(0); x++)
                {
                    var value = Map[x, y];
                    Console.Write(string.Format("{0}", value == 0 ? "." : value.ToString()));
                }
                Console.Write(Environment.NewLine);
            }
        }

        public int CountOverlappingVents()
        {
            var count = 0;
            for (int x = 0; x < Map.GetLength(0); x++)
            {
                for (int y = 0; y < Map.GetLength(1); y++)
                {
                    if (Map[x, y] > 1) count++;
                }
            }
            return count;
        }

        internal class Vent
        {
            public Point Start
            {
                get; private set;
            }

            public Point End
            {
                get; private set;
            }

            public Vent(string vector)
            {
                var coords = vector.Split(" -> ");
                var start = coords[0].Split(",");
                var end = coords[1].Split(",");
                this.Start = new Point(int.Parse(start[0]), int.Parse(start[1]));
                this.End = new Point(int.Parse(end[0]), int.Parse(end[1]));
            }

            public override string ToString()
            {
                return $"{Start.X},{Start.Y} -> {End.X},{End.Y}";
            }
        }
    }
}