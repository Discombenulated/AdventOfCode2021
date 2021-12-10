using NUnit.Framework;
using AdventOfCode.DayEight;

namespace AdventOfCode.Test.DayEight;

public class SignalPatternTest
{
    [Test]
    public void ShouldCountEasyNumbers()
    {
        var pattern = SignalPattern.FromEntry("acedgfb cdfbe gcdfa fbcad dab cefabd cdfgeb eafb cagedb ab | cagedb dab abd ba cdbaf");
        Assert.AreEqual(3, pattern.CountEasyNumbersInOutput());
    }

    [Test]
    public void DigitsAreEqual()
    {
        var d1 = new SignalPattern.Digit("ab");
        var d2 = new SignalPattern.Digit("ba");
        Assert.AreEqual(d1, d2);
    }

    [Test]
    public void ShouldDecodeNine()
    {
        var pattern = SignalPattern.FromEntry("acedgfb cdfbe gcdfa fbcad dab cefabd cdfgeb eafb cagedb ab | cefabd");
        Assert.AreEqual(9, pattern.OutputValue);
    }

    [Test]
    public void ShouldDecodeThree()
    {
        var pattern = SignalPattern.FromEntry("acedgfb cdfbe gcdfa fbcad dab cefabd cdfgeb eafb cagedb ab | fbcad");
        Assert.AreEqual(3, pattern.OutputValue);
    }

    [Test]
    public void ShouldDecodeSix()
    {
        var pattern = SignalPattern.FromEntry("acedgfb cdfbe gcdfa fbcad dab cefabd cdfgeb eafb cagedb ab | cdfgeb");
        Assert.AreEqual(6, pattern.OutputValue);
    }

    [Test]
    public void ShouldCalculateOutputValue()
    {
        var pattern = SignalPattern.FromEntry("acedgfb cdfbe gcdfa fbcad dab cefabd cdfgeb eafb cagedb ab | cdfeb fcadb cdfeb cdbaf");
        Assert.AreEqual(5353, pattern.OutputValue);
    }
}