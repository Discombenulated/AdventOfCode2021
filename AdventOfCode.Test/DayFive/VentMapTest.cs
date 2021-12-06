using NUnit.Framework;
using AdventOfCode.DayFive;
using System.Linq;

namespace AdventOfCode.Test.DayFive;

public class VentMapTest
{
    [Test]
    public void NoOverlappingVents()
    {
        var map = new VentMap(new string[] { "0,9 -> 5,9", "1,8 -> 4,8" });
        Assert.AreEqual(0, map.CountOverlappingVents());
    }

    [Test]
    public void OneOverlappingVent()
    {
        var map = new VentMap(new string[] { "0,9 -> 5,9", "1,9 -> 1,6" });
        Assert.AreEqual(1, map.CountOverlappingVents());
    }
}