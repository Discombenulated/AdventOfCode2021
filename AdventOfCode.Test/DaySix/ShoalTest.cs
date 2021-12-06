using NUnit.Framework;
using AdventOfCode.DaySix;
using System.Linq;

namespace AdventOfCode.Test.DaySix;

public class ShaolTest
{

    [Test]
    public void ShouldCountOneFishAfterOneDay()
    {
        var shoal = new Shoal(new int[] { 6 });
        var count = shoal.CountOnDay(1);
        Assert.AreEqual(1, count);
    }

    [Test]
    public void ShouldCountTwoFishAfterOneDay()
    {
        var shoal = new Shoal(new int[] { 6, 1 });
        var count = shoal.CountOnDay(1);
        Assert.AreEqual(2, count);
    }

    [Test]
    public void ShouldCreateNewFishAfterTwoDays()
    {
        var shoal = new Shoal(new int[] { 6, 1 });
        var count = shoal.CountOnDay(2);
        Assert.AreEqual(3, count);
    }
}