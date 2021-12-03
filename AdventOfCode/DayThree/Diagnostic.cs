namespace AdventOfCode.DayThree;

public class Diagnostic
{
    private string[] input;
    private Dictionary<int, int[]> bitCounts;

    public Diagnostic(string[] input)
    {
        this.input = input;
        CountBits();
    }

    private void CountBits()
    {
        SetupBitCounter();

        for (var lineIndex = 0; lineIndex < input.Length; lineIndex++)
        {
            var line = input[lineIndex];
            for (var bitIndex = 0; bitIndex < line.Length; bitIndex++)
            {
                var bit = int.Parse($"{line[bitIndex]}");
                bitCounts[bitIndex][bit]++;
            }
        }
    }

    private void SetupBitCounter()
    {
        bitCounts = new();
        for (var bitIndex = 0; bitIndex < input[0].Length; bitIndex++)
        {
            bitCounts.Add(bitIndex, new int[] { 0, 0 });
        }
    }

    public int GammaRate
    {
        get
        {
            string mostCommonBits = "";
            foreach (var bitIndex in bitCounts)
            {
                mostCommonBits += bitIndex.Value[0] > bitIndex.Value[1] ? "0" : "1";
            }
            return Convert.ToInt32(mostCommonBits, 2);
        }
    }

    public int EpslionRate
    {
        get
        {
            string leastCommonBits = "";
            foreach (var bitIndex in bitCounts)
            {
                leastCommonBits += bitIndex.Value[0] < bitIndex.Value[1] ? "0" : "1";
            }
            return Convert.ToInt32(leastCommonBits, 2);
        }
    }

    public int PowerConsumption
    {
        get
        {
            return EpslionRate * GammaRate;
        }
    }

    public int OxygenGeneratorRating
    {
        get
        {
            var lines = input;
            var answer = "";
            for (var position = 0; position < input[0].Length; position++)
            {
                var mostCommon = MostCommonBit(lines, position);
                answer += mostCommon;
                lines = lines.Where(l => $"{l[position]}" == mostCommon).ToArray();
                Console.WriteLine($"Lines left: {lines.Length}");
                if (lines.Length == 1)
                {
                    answer = lines[0];
                    break;
                };
            }
            return Convert.ToInt32(answer, 2);
        }
    }

    public int CO2ScrubberRating
    {
        get
        {
            var lines = input;
            var answer = "";
            for (var position = 0; position < input[0].Length; position++)
            {
                var leastCommon = LeastCommonBit(lines, position);
                answer += leastCommon;
                lines = lines.Where(l => $"{l[position]}" == leastCommon).ToArray();
                Console.WriteLine($"Lines left: {lines.Length}");
                if (lines.Length == 1)
                {
                    answer = lines[0];
                    break;
                };
            }
            Console.WriteLine(answer);
            return Convert.ToInt32(answer, 2);
        }
    }

    public int LifeSupportRating
    {
        get
        {
            return OxygenGeneratorRating * CO2ScrubberRating;
        }
    }

    private string MostCommonBit(string[] lines, int position)
    {
        var sum = 0;
        for (var lineIndex = 0; lineIndex < lines.Length; lineIndex++)
        {
            var line = lines[lineIndex];
            var bit = int.Parse($"{line[position]}");
            sum += bit;
        }
        return sum < ((double)lines.Length / 2.0) ? "0" : "1";
    }

    private string LeastCommonBit(string[] lines, int position)
    {
        var sum = 0;
        for (var lineIndex = 0; lineIndex < lines.Length; lineIndex++)
        {
            var line = lines[lineIndex];
            var bit = int.Parse($"{line[position]}");
            sum += bit;
        }
        return sum >= ((double)lines.Length / 2.0) ? "0" : "1";
    }
}