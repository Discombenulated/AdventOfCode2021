using NUnit.Framework;
using AdventOfCode.DaySeven;
using System.Linq;

namespace AdventOfCode.Test.DaySeven;

public class TaskOneTest
{

    [Test]
    public void ExampleInputFromFile()
    {
        var input = new FileInput("DaySeven/ExampleInput.txt").ReadAsCommaSepratedInt();
        var swarm = new CrabSwarm(input);
        Assert.AreEqual(37, swarm.AlignToBestPosition());
    }

    [Test]
    public void MyInputFromFile()
    {
        var input = new FileInput("DaySeven/MyInput.txt").ReadAsCommaSepratedInt();
        var swarm = new CrabSwarm(input);
        Assert.AreEqual(352707, swarm.AlignToBestPosition());
    }
}