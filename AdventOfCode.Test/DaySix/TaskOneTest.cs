using NUnit.Framework;
using AdventOfCode.DaySix;
using System.Linq;

namespace AdventOfCode.Test.DaySix;

public class TaskOneTest
{

    [Test]
    public void ExampleInputFromFile()
    {
        var input = new FileInput("DaySix/ExampleInput.txt").ReadAsCommaSepratedInt();
        var shoal = new Shoal(input);
        Assert.AreEqual(shoal.CountOnDay(18), 26);
        Assert.AreEqual(shoal.CountOnDay(80), 5934);
    }

    [Test]
    public void MyInputFromFile()
    {
        var input = new FileInput("DaySix/MyInput.txt").ReadAsCommaSepratedInt();
        var shoal = new Shoal(input);
        Assert.AreEqual(shoal.CountOnDay(80), 371379);
    }
}