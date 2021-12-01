namespace AdventOfCode.DayOne;

public class Depth
{
    private readonly int[] measurements;
    public Depth(int[] measurements)
    {
        this.measurements = measurements;
    }

    public int CountIncreases()
    {
        int increases = 0;
        for (int i = 1; i < measurements.Length; i++)
        {
            if (measurements[i] > measurements[i - 1])
            {
                increases++;
            }
        }
        return increases;
    }

    public int CountWindowIncreases()
    {
        int increases = 0;
        int previousWindow = CountWindow(0, 3);
        for (int i = 1; i < measurements.Length - 2; i++)
        {
            var currentWindow = CountWindow(i, 3);
            if (currentWindow > previousWindow)
            {
                increases++;
            }
            previousWindow = currentWindow;
        }
        return increases;
    }

    private int CountWindow(int windowStart, int windowSize)
    {
        return measurements.Skip(windowStart).Take(windowSize).Sum();
    }
}