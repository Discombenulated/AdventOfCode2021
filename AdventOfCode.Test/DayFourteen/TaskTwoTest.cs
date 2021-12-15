using NUnit.Framework;
using AdventOfCode.DayFourteen;
using System.Linq;

namespace AdventOfCode.Test.DayFourteen;

public class TaskTwoTest
{
    [Test]
    public void ExampleInputFromFile()
    {
        var input = new FileInput("DayFourteen/ExampleInput.txt").ReadLines();
        var template = new PolymerTemplate(input[0]);
        string[] rulesStr = input.Skip(2).ToArray();
        var rules = new PolymerRules(rulesStr);
        //Assert.AreEqual(2188189693529, template.Insert(rules, 40).CheckSum);
    }

    [Test]
    public void MyInputFromFile()
    {
        var input = new FileInput("DayFourteen/MyInput.txt").ReadLines();
        var template = new PolymerTemplate(input[0]);
        string[] rulesStr = input.Skip(2).ToArray();
        var rules = new PolymerRules(rulesStr);
        //Assert.AreEqual(3213, template.Insert(rules, 40).CheckSum);
    }
}