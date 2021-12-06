using NUnit.Framework;
using AdventOfCode.DayFive;
using System.Linq;

namespace AdventOfCode.Test.DayFive;

public class TaskOneTest
{

    [Test]
    public void ExampleInputFromFile()
    {
        var input = new FileInput("DayFive/ExampleInput.txt").ReadLines();
        var map = new VentMap(input, false);
        Assert.AreEqual(5, map.CountOverlappingVents());
    }

    [Test]
    public void MyInputFromFile()
    {
        var input = new FileInput("DayFive/MyInput.txt").ReadLines();
        var map = new VentMap(input, false);
        Assert.AreEqual(6856, map.CountOverlappingVents());
    }
}