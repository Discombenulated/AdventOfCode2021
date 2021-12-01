namespace AdventOfCode;

public class FileInput
{
    private readonly string path;

    public FileInput(string path)
    {
        this.path = path;
    }

    public string[] ReadLines()
    {
        return File.ReadAllLines(path);
    }

    public int[] ReadLinesAsInt()
    {
        var lines = ReadLines();
        return lines.Select(line => int.Parse(line)).ToArray();
    }
}