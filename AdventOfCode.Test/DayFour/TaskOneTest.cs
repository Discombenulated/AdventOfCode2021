using NUnit.Framework;
using AdventOfCode.DayFour;
using System.Linq;

namespace AdventOfCode.Test.DayFour;

public class TaskOneTest
{

    [Test]
    public void ExampleInputFromFile()
    {
        var input = new FileInput("DayFour/ExampleInput.txt").ReadLines();
        var bingo = BingoGame.WithBoards(input.Skip(2).ToArray());
        var score = bingo.FinalScoreWithNumbersCalled(input.First());
        Assert.AreEqual(4512, score);
    }

    [Test]
    public void MyInputFromFile()
    {
        var input = new FileInput("DayFour/MyInput.txt").ReadLines();
        var bingo = BingoGame.WithBoards(input.Skip(2).ToArray());
        var score = bingo.FinalScoreWithNumbersCalled(input.First());
        Assert.AreEqual(41668, score);
    }
}