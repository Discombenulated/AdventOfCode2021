using NUnit.Framework;
using AdventOfCode.DayNine;
using System.Linq;

namespace AdventOfCode.Test.DayNine;

public class TaskOneTest
{

    [Test]
    public void ExampleInputFromFile()
    {
        var input = new FileInput("DayNine/ExampleInput.txt").ReadLines();
        var map = new SmokeMap(input);
        Assert.AreEqual(15, map.RiskLevel);
    }

    [Test]
    public void MyInputFromFile()
    {
        var input = new FileInput("DayNine/MyInput.txt").ReadLines();
        var map = new SmokeMap(input);
        Assert.AreEqual(502, map.RiskLevel);
    }
}