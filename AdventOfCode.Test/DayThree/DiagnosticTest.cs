using NUnit.Framework;
using AdventOfCode.DayThree;

namespace AdventOfCode.Test.DayThree;

public class DiagnosticTest
{
    [Test]
    public void ShouldCalculateGammaRate()
    {
        var input = new string[] { "001", "010", "011", "111", "111" };
        //most common bit = 0,1, 1 = 3
        var diagnostic = new Diagnostic(input);
        Assert.AreEqual(3, diagnostic.GammaRate);
    }
}