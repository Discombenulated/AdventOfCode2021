using NUnit.Framework;
using AdventOfCode.DayTwo;

namespace AdventOfCode.Test.DayTwo;

public class TaskOneTest
{
    [Test]
    public void ExampleInputFromFile()
    {
        var input = new FileInput("DayTwo/ExampleInput.txt").ReadLines();
        var nav = new Navigate();
        nav.Move(input);
        Assert.AreEqual(15, nav.HorizontalPosition);
        Assert.AreEqual(10, nav.Depth);
        Assert.AreEqual(150, nav.Checksum);
    }

    [Test]
    public void MyInputFromFile()
    {
        var input = new FileInput("DayTwo/MyInput.txt").ReadLines();
        var nav = new Navigate();
        nav.Move(input);
        Assert.AreEqual(1962940, nav.Checksum);
    }
}