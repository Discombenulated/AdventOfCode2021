namespace AdventOfCode.DayFour
{
    public class Board
    {
        private const int DIMENSION = 5;
        private Number[][] numbers = new Number[DIMENSION][];

        public int Score
        {
            get
            {
                return numbers.Sum(line => line.Sum(num => num.Marked ? 0 : num.Value));
            }
        }

        public Board(string[] lines)
        {
            for (int y = 0; y < lines.Length; y++)
            {
                numbers[y] = lines[y].Split(" ").Where(s => s.Trim().Length > 0).Select(l => new Number(int.Parse(l))).ToArray();
            }
        }

        public bool CallNumber(int numberCalled)
        {
            foreach (var line in numbers)
            {
                foreach (var num in line)
                {
                    if (num.Value == numberCalled) num.Marked = true;
                }
            }
            return HasWon();
        }

        private bool HasWon()
        {
            for (int y = 0; y < numbers.Length; y++)
            {
                if (AreAllNumbersMarked(numbers[y])) return true;
            }
            for (int x = 0; x < DIMENSION; x++)
            {
                if (AreAllNumbersMarked(GetColumn(x))) return true;

            }
            return false;
        }

        private Number[] GetColumn(int columnNumber)
        {
            return Enumerable.Range(0, numbers.GetLength(0))
                    .Select(x => numbers[x][columnNumber])
                    .ToArray();
        }

        private bool AreAllNumbersMarked(Number[] nums)
        {
            return nums.Where(n => n.Marked).Count() == nums.Length;
        }
    }

    internal class Number
    {
        public int Value;
        public bool Marked = false;

        internal Number(int value)
        {
            this.Value = value;
        }
    }
}