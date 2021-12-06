using NUnit.Framework;
using AdventOfCode.DaySix;
using System.Linq;

namespace AdventOfCode.Test.DaySix;

public class TaskTwoTest
{
    [Test]
    public void ExampleInputFromFile()
    {
        var input = new FileInput("DaySix/ExampleInput.txt").ReadAsCommaSepratedInt();
        var shoal = new Shoal(input);
        Assert.AreEqual(26984457539, shoal.CountOnDay(256));
    }

    [Test]
    public void MyInputFromFile()
    {
        var input = new FileInput("DaySix/MyInput.txt").ReadAsCommaSepratedInt();
        var shoal = new Shoal(input);
        Assert.AreEqual(1674303997472, shoal.CountOnDay(256));
    }
}