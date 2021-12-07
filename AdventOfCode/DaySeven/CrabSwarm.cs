namespace AdventOfCode.DaySeven
{
    public class CrabSwarm
    {
        private int[] horizontalPositions;

        public CrabSwarm(int[] input)
        {
            this.horizontalPositions = input;
        }

        public int AlignToBestPosition()
        {
            var max = this.horizontalPositions.Max();
            var min = this.horizontalPositions.Min();
            var bestFuel = int.MaxValue;
            var bestPosition = min;
            for (int attempt = min; attempt <= max; attempt++)
            {
                int fuel = CalculateFuel(attempt);
                if (fuel < bestFuel)
                {
                    bestFuel = fuel;
                    bestPosition = attempt;
                }
                //Console.WriteLine($"Fuel: {fuel}, Position: {attempt}");
            }
            Console.WriteLine($"BEST Fuel: {bestFuel}, Position: {bestPosition}");
            return bestFuel;
        }

        private int CalculateFuel(int attempt)
        {
            return this.horizontalPositions.Sum(p => Math.Abs(p - attempt));
        }

        private int Median(int[] input)
        {
            var sorted = input.OrderBy(p => p).ToList();
            return sorted[sorted.Count() / 2];
        }
    }
}