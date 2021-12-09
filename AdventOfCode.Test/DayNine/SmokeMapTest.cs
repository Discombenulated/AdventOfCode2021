using NUnit.Framework;
using AdventOfCode.DayNine;
using System.Linq;

namespace AdventOfCode.Test.DayNine;

public class SmokeMapTest
{

    [Test]
    public void ShouldFindSingleLowPointRiskLevel2()
    {
        var map = new SmokeMap(new string[] { "999", "919", "999" });
        Assert.AreEqual(2, map.RiskLevel);
    }

    [Test]
    public void ShouldFindBasinSize3()
    {
        var map = new SmokeMap(new string[] { "219", "399", "999" });
        Assert.AreEqual(3, map.LargestBasinsCompliment);
    }
}