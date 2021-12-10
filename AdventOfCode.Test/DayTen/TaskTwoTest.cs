using NUnit.Framework;
using AdventOfCode.DayTen;
using System.Linq;

namespace AdventOfCode.Test.DayTen;

public class TaskTwoTest
{
    [Test]
    public void ExampleInputFromFile()
    {
        var input = new FileInput("DayTen/ExampleInput.txt").ReadLines();
        var nav = new NavInstructions(input);
        Assert.AreEqual(288957, nav.CompletionScore);
    }

    [Test]
    public void MyInputFromFile()
    {
        var input = new FileInput("DayTen/MyInput.txt").ReadLines();
        var nav = new NavInstructions(input);
        Assert.AreEqual(3103006161, nav.CompletionScore);
    }
}