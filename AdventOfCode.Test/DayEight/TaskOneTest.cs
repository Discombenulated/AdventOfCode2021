using NUnit.Framework;
using AdventOfCode.DayEight;
using System.Linq;

namespace AdventOfCode.Test.DayEight;

public class TaskOneTest
{

    [Test]
    public void ExampleInputFromFile()
    {
        var input = new FileInput("DayEight/ExampleInput.txt").ReadLines();
        Assert.AreEqual(26, SignalPattern.Count1478(input));
    }

    [Test]
    public void MyInputFromFile()
    {
        var input = new FileInput("DayEight/MyInput.txt").ReadLines();
        Assert.AreEqual(318, SignalPattern.Count1478(input));
    }
}