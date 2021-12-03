using NUnit.Framework;
using AdventOfCode.DayThree;

namespace AdventOfCode.Test.DayThree;

public class TaskTwoTest
{
    [Test]
    public void ExampleInputFromFile_OxygenGenerator()
    {
        var input = new FileInput("DayThree/ExampleInput.txt").ReadLines();
        var diagnostic = new Diagnostic(input);
        Assert.AreEqual(23, diagnostic.OxygenGeneratorRating);
    }

    [Test]
    public void ExampleInputFromFile_CO2ScrubberRating()
    {
        var input = new FileInput("DayThree/ExampleInput.txt").ReadLines();
        var diagnostic = new Diagnostic(input);
        Assert.AreEqual(10, diagnostic.CO2ScrubberRating);
    }

    [Test]
    public void ExampleInputFromFile()
    {
        var input = new FileInput("DayThree/ExampleInput.txt").ReadLines();
        var diagnostic = new Diagnostic(input);
        Assert.AreEqual(230, diagnostic.LifeSupportRating);
    }

    [Test]
    public void MyInputFromFile()
    {
        var input = new FileInput("DayThree/MyInput.txt").ReadLines();
        var diagnostic = new Diagnostic(input);
        Assert.AreEqual(5852595, diagnostic.LifeSupportRating);
    }
}