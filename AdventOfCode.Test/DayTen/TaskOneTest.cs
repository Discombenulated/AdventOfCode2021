using NUnit.Framework;
using AdventOfCode.DayTen;
using System.Linq;

namespace AdventOfCode.Test.DayTen;

public class TaskOneTest
{

    [Test]
    public void ExampleInputFromFile()
    {
        var input = new FileInput("DayTen/ExampleInput.txt").ReadLines();
        var nav = new NavInstructions(input);
        Assert.AreEqual(26397, nav.SyntaxErrorScore);
    }

    [Test]
    public void MyInputFromFile()
    {
        var input = new FileInput("DayTen/MyInput.txt").ReadLines();
        var nav = new NavInstructions(input);
        Assert.AreEqual(323613, nav.SyntaxErrorScore);
    }
}