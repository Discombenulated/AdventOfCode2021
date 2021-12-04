using NUnit.Framework;
using AdventOfCode.DayFour;
using System.Linq;

namespace AdventOfCode.Test.DayFour;

public class BoardTest
{

    [Test]
    public void ShouldWinWithHorizontal()
    {
        var board = new Board(new string[]{"22 13 17 11  0",
                                           " 8  2 23  4 24",
                                           "21  9 14 16  7",
                                           " 6 10  3 18  5",
                                           " 1 12 20 15 19"});
        Assert.IsFalse(board.CallNumber(8));
        Assert.IsFalse(board.CallNumber(2));
        Assert.IsFalse(board.CallNumber(23));
        Assert.IsFalse(board.CallNumber(4));
        Assert.IsTrue(board.CallNumber(24));
    }

    [Test]
    public void ShouldWinWithVertical()
    {
        var board = new Board(new string[]{"22 13 17 11  0",
                                           " 8  2 23  4 24",
                                           "21  9 14 16  7",
                                           " 6 10  3 18  5",
                                           " 1 12 20 15 19"});
        Assert.IsFalse(board.CallNumber(13));
        Assert.IsFalse(board.CallNumber(2));
        Assert.IsFalse(board.CallNumber(9));
        Assert.IsFalse(board.CallNumber(10));
        Assert.IsTrue(board.CallNumber(12));
    }

    [Test]
    public void ShouldCalculateSumOfUnmarkedNumbers()
    {
        var board = new Board(new string[]{"14 21 17 24  4",
                                           "10 16 15  9 19",
                                           "18  8 23 26 20",
                                           "22 11 13  6  5",
                                           " 2  0 12  3  7"});
        board.CallNumber(7);
        board.CallNumber(4);
        board.CallNumber(9);
        board.CallNumber(5);
        board.CallNumber(11);
        board.CallNumber(17);
        board.CallNumber(23);
        board.CallNumber(2);
        board.CallNumber(0);
        board.CallNumber(14);
        Assert.IsFalse(board.CallNumber(21));
        Assert.IsTrue(board.CallNumber(24));
        Assert.AreEqual(188, board.Score);
    }
}