using NUnit.Framework;
using AdventOfCode;
using AdventOfCode.DayOne;

namespace AdventOfCode.Test.DayOne;

public class DepthTest
{
    [Test]
    public void ShouldDetectIncreaseOfOne()
    {
        var depth = new Depth(new int[] { 199, 200 });
        Assert.AreEqual(1, depth.CountIncreases());
    }

    [Test]
    public void ShouldMeasureWindowToFindOneIncrease()
    {
        var depth = new Depth(new int[] { 1, 2, 3, 4 });
        Assert.AreEqual(1, depth.CountWindowIncreases());
    }
}