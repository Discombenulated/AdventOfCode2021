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
}