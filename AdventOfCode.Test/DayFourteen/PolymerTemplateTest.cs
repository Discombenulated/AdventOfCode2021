using NUnit.Framework;
using AdventOfCode.DayFourteen;
using System.Linq;

namespace AdventOfCode.Test.DayFourteen;

public class PolymerTemplateTest
{
    [Test]
    public void ShouldBeEqual()
    {
        var pol1 = new PolymerTemplate("NNCB");
        var pol2 = new PolymerTemplate("NNCB");
        Assert.AreEqual(pol1, pol2);
    }

    [Test]
    public void ShouldNotBeEqual()
    {
        var pol1 = new PolymerTemplate("NNCB");
        var pol2 = new PolymerTemplate("BCNN");
        Assert.AreNotEqual(pol1, pol2);
    }

    [Test]
    public void SimpleInsertion()
    {
        var template = new PolymerTemplate("NNCB");
        var rules = new PolymerRules(new string[] { "NC -> D" });
        var expected = new PolymerTemplate("NNDCB");
        Assert.AreEqual(expected, template.Insert(rules));
    }

    [Test]
    public void DoubleInsertion()
    {
        var template = new PolymerTemplate("NNCB");
        var rules = new PolymerRules(new string[] { "NC -> D", "NN -> D" });
        var expected = new PolymerTemplate("NDNDCB");
        Assert.AreEqual(expected, template.Insert(rules));
    }

    [Test]
    public void NoInsertion()
    {
        var template = new PolymerTemplate("NNCB");
        var rules = new PolymerRules(new string[] { "NB -> D" });
        var expected = new PolymerTemplate("NNCB");
        Assert.AreEqual(expected, template.Insert(rules));
    }

    [Test]
    public void InsertionAfter2Steps()
    {
        var template = new PolymerTemplate("NNCB");
        var rules = new PolymerRules(new string[] { "NC -> D", "ND -> E" });
        var expected = new PolymerTemplate("NNEDCB");
        Assert.AreEqual(expected, template.Insert(rules, 2));
    }
}