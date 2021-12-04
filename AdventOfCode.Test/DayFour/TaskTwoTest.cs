using NUnit.Framework;
using AdventOfCode.DayFour;
using System.Linq;

namespace AdventOfCode.Test.DayFour;

public class TaskTwoTest
{
    [Test]
    public void ExampleInputFromFile()
    {
        var input = new FileInput("DayFour/ExampleInput.txt").ReadLines();
        var bingo = BingoGame.WithBoards(input.Skip(2).ToArray());
        var score = bingo.FinalScoreOfWorstGame(input.First());
        Assert.AreEqual(1924, score);
    }

    [Test]
    public void MyInputFromFile()
    {
        var input = new FileInput("DayFour/MyInput.txt").ReadLines();
        var bingo = BingoGame.WithBoards(input.Skip(2).ToArray());
        var score = bingo.FinalScoreOfWorstGame(input.First());
        Assert.AreEqual(10478, score);
    }
}