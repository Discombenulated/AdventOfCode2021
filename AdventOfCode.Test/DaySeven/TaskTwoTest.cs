using NUnit.Framework;
using AdventOfCode.DaySeven;
using System.Linq;

namespace AdventOfCode.Test.DaySeven;

public class TaskTwoTest
{
    [Test]
    public void ExampleInputFromFile()
    {
        var input = new FileInput("DaySeven/ExampleInput.txt").ReadAsCommaSepratedInt();
        var swarm = new ExpensiveCrabSwarm(input);
        Assert.AreEqual(168, swarm.AlignToBestPosition());
    }

    [Test]
    public void MyInputFromFile()
    {
        var input = new FileInput("DaySeven/MyInput.txt").ReadAsCommaSepratedInt();
        var swarm = new ExpensiveCrabSwarm(input);
        Assert.AreEqual(95519693, swarm.AlignToBestPosition());
    }
}