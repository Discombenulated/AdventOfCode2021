using NUnit.Framework;
using AdventOfCode.DayTwo;

namespace AdventOfCode.Test.DayTwo;

public class TaskTwoTest
{
    [Test]
    public void ExampleInputFromFile()
    {
        var input = new FileInput("DayTwo/ExampleInput.txt").ReadLines();
        var nav = new NavigateWithAim();
        nav.Move(input);
        Assert.AreEqual(15, nav.HorizontalPosition);
        Assert.AreEqual(60, nav.Depth);
        Assert.AreEqual(900, nav.Checksum);
    }

    [Test]
    public void MyInputFromFile()
    {
        var input = new FileInput("DayTwo/MyInput.txt").ReadLines();
        var nav = new NavigateWithAim();
        nav.Move(input);
        Assert.AreEqual(1813664422, nav.Checksum);
    }
}