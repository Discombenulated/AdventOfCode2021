namespace AdventOfCode.DaySix
{
    public class Shoal
    {
        private readonly List<int> fish;

        public Shoal(int[] fish)
        {
            this.fish = fish.ToList();
        }

        public int CountOnDay_TaskOne(int numDays)
        {
            var fishCopy = fish.Select(f => f).ToList();
            Console.WriteLine($"Initial: {string.Join(", ", fishCopy)}");
            for (int day = 0; day < numDays; day++)
            {
                var numNewFish = 0;
                for (var i = 0; i < fishCopy.Count(); i++)
                {
                    fishCopy[i]--;
                    if (fishCopy[i] < 0)
                    {
                        numNewFish++;
                        fishCopy[i] = 6;
                    }
                }
                fishCopy.AddRange(Enumerable.Repeat(8, numNewFish));
                //Console.WriteLine($"After {day + 1}: {string.Join(", ", fishCopy)}");
            }
            return fishCopy.Count();
        }

        public long CountOnDay(int numDays)
        {
            var countByDaysLeft = new long[9];
            foreach (var f in fish)
            {
                countByDaysLeft[f]++;
            }
            Console.WriteLine($"Initial: {string.Join(", ", countByDaysLeft)}");

            for (int day = 0; day < numDays; day++)
            {
                var numNewFish = countByDaysLeft[0];
                for (int i = 0; i < countByDaysLeft.Length - 1; i++)
                {
                    countByDaysLeft[i] = countByDaysLeft[i + 1];
                }
                countByDaysLeft[6] += numNewFish;
                countByDaysLeft[8] = numNewFish;
                //Console.WriteLine($"After {day + 1}: {string.Join(", ", countByDaysLeft)}");
            }
            return countByDaysLeft.Sum();
        }
    }
}