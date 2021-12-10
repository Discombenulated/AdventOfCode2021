using NUnit.Framework;
using AdventOfCode.DayEight;
using System.Linq;

namespace AdventOfCode.Test.DayEight;

public class TaskTwoTest
{
    [Test]
    public void ExampleInputFromFile()
    {
        var input = new FileInput("DayEight/ExampleInput.txt").ReadLines();
        Assert.AreEqual(61229, SignalPattern.OutputValueOf(input));
    }

    [Test]
    public void MyInputFromFile()
    {
        var input = new FileInput("DayEight/MyInput.txt").ReadLines();
        Assert.AreEqual(996280, SignalPattern.OutputValueOf(input));
    }
}