using NUnit.Framework;
using AdventOfCode.DayTwo;

namespace AdventOfCode.Test.DayTwo;

public class NavigateTest
{
    [Test]
    public void ShouldMoveForward()
    {
        var nav = new Navigate();
        nav.Move("forward 5");
        nav.Move("forward 3");
        Assert.AreEqual(8, nav.HorizontalPosition);
    }

    [Test]
    public void ShouldMoveForwardWithMultipleInstructions()
    {
        var nav = new Navigate();
        nav.Move(new string[] { "forward 5", "forward 2" });
        Assert.AreEqual(7, nav.HorizontalPosition);
    }

    [Test]
    public void ShouldMoveUp()
    {
        var nav = new Navigate();
        nav.Move("up 3");
        nav.Move("up 6");
        Assert.AreEqual(-9, nav.Depth);
    }

    [Test]
    public void ShouldMoveDown()
    {
        var nav = new Navigate();
        nav.Move("down 4");
        nav.Move("down 6");
        Assert.AreEqual(10, nav.Depth);
    }

    [Test]
    public void ShouldCalculateChecksum()
    {
        var nav = new Navigate();
        nav.Move(new string[] { "forward 5", "down 4" });
        Assert.AreEqual(20, nav.Checksum);
    }
}