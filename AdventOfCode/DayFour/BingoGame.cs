namespace AdventOfCode.DayFour
{
    public class BingoGame
    {
        private List<Board> boards = new();
        public double WinningScore { get; }

        public static BingoGame WithBoards(string[] boardInput)
        {
            var game = new BingoGame();
            for (int line = 0; line < boardInput.Length; line += 6)
            {
                var board = new Board(boardInput.Skip(line).Take(5).ToArray());
                game.AddBoard(board);
            }
            return game;
        }

        private void AddBoard(Board board)
        {
            boards.Add(board);
        }

        public int FinalScoreWithNumbersCalled(string numbers)
        {
            return FinalScoreWithNumbersCalled(numbers.Split(",").Select(int.Parse).ToArray());
        }

        public int FinalScoreWithNumbersCalled(int[] numbers)
        {
            foreach (var number in numbers)
            {
                foreach (var board in boards)
                {
                    if (board.CallNumber(number))
                    {
                        return board.Score * number;
                    }
                }
            }
            throw new Exception("No winner!");
        }

        public int FinalScoreOfWorstGame(string numbers)
        {
            return FinalScoreOfWorstGame(numbers.Split(",").Select(int.Parse).ToArray());
        }

        public int FinalScoreOfWorstGame(int[] numbers)
        {
            var winningBoards = new List<Board>();
            foreach (var number in numbers)
            {
                foreach (var board in boards)
                {
                    if (!winningBoards.Contains(board) && board.CallNumber(number))
                    {
                        winningBoards.Add(board);
                        if (winningBoards.Count() == boards.Count())
                        {
                            return winningBoards.Last().Score * number;
                        }
                    }
                }
            }
            throw new Exception("No winner!");
        }
    }
}