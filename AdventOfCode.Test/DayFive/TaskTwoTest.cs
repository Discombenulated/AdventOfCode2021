using NUnit.Framework;
using AdventOfCode.DayFive;
using System.Linq;

namespace AdventOfCode.Test.DayFive;

public class TaskTwoTest
{
    [Test]
    public void ExampleInputFromFile()
    {
        var input = new FileInput("DayFive/ExampleInput.txt").ReadLines();
        var map = new VentMap(input);
        Assert.AreEqual(12, map.CountOverlappingVents());
    }

    [Test]
    public void MyInputFromFile()
    {
        var input = new FileInput("DayFive/MyInput.txt").ReadLines();
        var map = new VentMap(input);
        Assert.AreEqual(20666, map.CountOverlappingVents());
    }
}