using System.Drawing;

namespace AdventOfCode.DayNine
{
    public class SmokeMap
    {
        private string[] input;

        public SmokeMap(string[] input)
        {
            this.input = input;
        }

        public int RiskLevel
        {
            get
            {
                var lowestPoints = BasinLocations();
                return lowestPoints.Select(p => GetHeightAt(p.X, p.Y) + 1).Sum();
            }
        }

        public int LargestBasinsCompliment
        {
            get
            {
                var lowestPoints = BasinLocations();
                Console.WriteLine($"Low Points found: {lowestPoints.Count()}");
                var points = lowestPoints.Select(p => BasinSize(p)).OrderByDescending(h => h).Take(3);
                Console.WriteLine($"Points found: {points.Count()}");
                return points.Aggregate(1, (acc, val) => acc * val);
            }
        }

        private List<Point> BasinLocations()
        {
            var lowestPoints = new List<Point>();
            for (int x = 0; x < input[0].Length; x++)
            {
                for (int y = 0; y < input.Length; y++)
                {
                    var currentHeight = GetHeightAt(x, y);
                    //Left
                    if (x > 0 && GetHeightAt(x - 1, y) <= currentHeight) continue;
                    //Down
                    if (y > 0 && GetHeightAt(x, y - 1) <= currentHeight) continue;
                    //Right
                    if (x < input[y].Length - 1 && GetHeightAt(x + 1, y) <= currentHeight) continue;
                    //Up
                    if (y < input.Length - 1 && GetHeightAt(x, y + 1) <= currentHeight) continue;

                    //Adjacent points are all equal or higher
                    lowestPoints.Add(new Point(x, y));
                }
            }
            return lowestPoints;
        }

        private int BasinSize(Point lowestPoint)
        {
            var pointsInBasin = new List<Point>();
            BasinSize(lowestPoint, ref pointsInBasin);
            return pointsInBasin.Count();
        }

        private void BasinSize(Point p, ref List<Point> visited)
        {
            if (visited.Contains(p)) return;
            var currentHeight = GetHeightAt(p.X, p.Y);
            if (currentHeight >= 9) return;
            visited.Add(p);
            //Left
            if (p.X > 0)
            {
                var left = new Point(p.X - 1, p.Y);
                BasinSize(left, ref visited);
            }
            //Down
            if (p.Y > 0)
            {
                var down = new Point(p.X, p.Y - 1);
                BasinSize(down, ref visited);
            }
            //Right
            if (p.X < input[p.Y].Length - 1)
            {
                var right = new Point(p.X + 1, p.Y);
                BasinSize(right, ref visited);
            }
            //Up
            if (p.Y < input.Length - 1)
            {
                var up = new Point(p.X, p.Y + 1);
                BasinSize(up, ref visited);
            }
        }

        private int GetHeightAt(int x, int y)
        {
            return int.Parse($"{input[y][x]}");
        }
    }
}