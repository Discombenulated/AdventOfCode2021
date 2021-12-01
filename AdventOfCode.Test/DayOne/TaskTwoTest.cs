using NUnit.Framework;
using AdventOfCode;
using AdventOfCode.DayOne;

namespace AdventOfCode.Test.DayOne;

public class TaskTwoTest
{
    [Test]
    public void ExampleInputFromFile()
    {
        var input = new FileInput("DayOne/ExampleInput.txt").ReadLinesAsInt();
        var depth = new Depth(input);
        Assert.AreEqual(5, depth.CountWindowIncreases());
    }

    [Test]
    public void MyInputFromFile()
    {
        var input = new FileInput("DayOne/MyInput.txt").ReadLinesAsInt();
        var depth = new Depth(input);
        Assert.AreEqual(1571, depth.CountWindowIncreases());
    }
}