using NUnit.Framework;
using AdventOfCode;
using AdventOfCode.DayOne;

namespace AdventOfCode.Test.DayOne;

public class TaskOneTest
{
    [Test]
    public void ExampleInputFromFile()
    {
        var input = new FileInput("DayOne/ExampleInput.txt").ReadLinesAsInt();
        var depth = new Depth(input);
        Assert.AreEqual(7, depth.CountIncreases());
    }

    [Test]
    public void MyInputFromFile()
    {
        var input = new FileInput("DayOne/MyInput.txt").ReadLinesAsInt();
        var depth = new Depth(input);
        Assert.AreEqual(1532, depth.CountIncreases());
    }
}