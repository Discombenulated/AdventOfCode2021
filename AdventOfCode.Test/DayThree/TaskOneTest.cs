using NUnit.Framework;
using AdventOfCode.DayThree;

namespace AdventOfCode.Test.DayThree;

public class TaskOneTest
{

    [Test]
    public void ExampleInputFromFile_GammaRate()
    {
        var input = new FileInput("DayThree/ExampleInput.txt").ReadLines();
        var diagnostic = new Diagnostic(input);
        Assert.AreEqual(22, diagnostic.GammaRate);
    }

    [Test]
    public void ExampleInputFromFile_EpsilonRate()
    {
        var input = new FileInput("DayThree/ExampleInput.txt").ReadLines();
        var diagnostic = new Diagnostic(input);
        Assert.AreEqual(9, diagnostic.EpslionRate);
    }

    [Test]
    public void ExampleInputFromFile_PowerConsumption()
    {
        var input = new FileInput("DayThree/ExampleInput.txt").ReadLines();
        var diagnostic = new Diagnostic(input);
        Assert.AreEqual(198, diagnostic.PowerConsumption);
    }

    [Test]
    public void MyInputFromFile()
    {
        var input = new FileInput("DayThree/MyInput.txt").ReadLines();
        var diagnostic = new Diagnostic(input);
        Assert.AreEqual(3923414, diagnostic.PowerConsumption);
    }
}