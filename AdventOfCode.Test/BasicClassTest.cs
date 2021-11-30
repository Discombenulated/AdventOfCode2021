using NUnit.Framework;

namespace AdventOfCode.Test;

public class BasicClassTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var bc = new BasicClass();
        Assert.IsTrue(bc.TestsWork());
    }

    [Test]
    public void Test2()
    {
        var bc = new BasicClass();
        Assert.AreEqual(true, bc.TestsWork());
    }
}