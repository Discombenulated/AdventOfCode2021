using NUnit.Framework;
using AdventOfCode.DayNine;
using System.Linq;

namespace AdventOfCode.Test.DayNine;

public class TaskTwoTest
{
    [Test]
    public void ExampleInputFromFile()
    {
        var input = new FileInput("DayNine/ExampleInput.txt").ReadLines();
        var map = new SmokeMap(input);
        Assert.AreEqual(1134, map.LargestBasinsCompliment);
    }

    [Test]
    public void MyInputFromFile()
    {
        var input = new FileInput("DayNine/MyInput.txt").ReadLines();
        var map = new SmokeMap(input);
        Assert.AreEqual(1330560, map.LargestBasinsCompliment);
    }
}