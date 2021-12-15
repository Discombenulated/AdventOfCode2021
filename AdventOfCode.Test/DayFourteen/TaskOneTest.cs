using NUnit.Framework;
using AdventOfCode.DayFourteen;
using System.Linq;

namespace AdventOfCode.Test.DayFourteen;

public class TaskOneTest
{

    [Test]
    public void ExampleInputFromFile()
    {
        var input = new FileInput("DayFourteen/ExampleInput.txt").ReadLines();
        var template = new PolymerTemplate(input[0]);
        string[] rulesStr = input.Skip(2).ToArray();
        var rules = new PolymerRules(rulesStr);
        var expectedPolymer = new PolymerTemplate("NBBNBNBBCCNBCNCCNBBNBBNBBBNBBNBBCBHCBHHNHCBBCBHCB");
        Assert.AreEqual(expectedPolymer, template.Insert(rules, 4));
        Assert.AreEqual(1588, template.Insert(rules, 10).CheckSum);
    }

    [Test]
    public void MyInputFromFile()
    {
        var input = new FileInput("DayFourteen/MyInput.txt").ReadLines();
        var template = new PolymerTemplate(input[0]);
        string[] rulesStr = input.Skip(2).ToArray();
        var rules = new PolymerRules(rulesStr);
        Assert.AreEqual(3213, template.Insert(rules, 10).CheckSum);
    }
}