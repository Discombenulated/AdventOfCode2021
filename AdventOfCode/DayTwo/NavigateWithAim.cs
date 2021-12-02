namespace AdventOfCode.DayTwo;

public class NavigateWithAim
{
    public int HorizontalPosition { get; private set; }
    public int Depth { get; private set; }

    private int Aim;

    public int Checksum
    {
        get
        {
            return HorizontalPosition * Depth;
        }
    }

    public void Move(string[] instructions)
    {
        foreach (var instruction in instructions)
        {
            Move(instruction);
        }
    }

    public void Move(string instruction)
    {
        var direction = instruction.Split(' ')[0];
        var amount = int.Parse(instruction.Split(' ')[1]);
        switch (direction)
        {
            case "forward":
                Forward(amount);
                break;
            case "up":
                Up(amount);
                break;
            case "down":
                Down(amount);
                break;
        }
    }

    private void Forward(int distance)
    {
        HorizontalPosition += distance;
        Depth += (Aim * distance);
    }

    private void Up(int distance)
    {
        Aim -= distance;
    }

    private void Down(int distance)
    {
        Aim += distance;
    }
}