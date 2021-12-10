namespace AdventOfCode.DayEight
{
    public class SignalPattern
    {
        private Dictionary<Digit, int> digitPatterns = new();
        private IEnumerable<Digit> input;
        private IEnumerable<Digit> output;

        public int OutputValue
        {
            get
            {
                var digits = output.Select(o => GetValue(o).ToString());
                var num = int.Parse($"{string.Join("", digits)}");
                return num;
            }
        }

        private SignalPattern(IEnumerable<Digit> input, IEnumerable<Digit> output)
        {
            this.input = input;
            this.output = output;
            DecodeInput();
        }

        public static SignalPattern FromEntry(string entry)
        {
            var splitEntry = entry.Split(" | ");
            var input = splitEntry[0].Split(" ").Select(o => new Digit(o));
            var output = splitEntry[1].Split(" ").Select(o => new Digit(o));
            return new SignalPattern(input, output);
        }

        private void DecodeInput()
        {
            //0 has 6 segments, including all segments from 1 and 7
            //2 has 5 segments, shares bottom segment with 1 & 6.
            //3 has 5 segments, including both segments from 1
            //5 has 5 segments, 
            //6 has 6 segments, including all segments from 5
            //9 has 6 segments, including all segments from 4 and 3

            var sequence = input.ToList();
            var one = sequence.Where(p => p.SegmentCount == 2).First();
            digitPatterns.Add(one, 1);
            sequence.Remove(one);
            var four = sequence.Where(p => p.SegmentCount == 4).First();
            digitPatterns.Add(four, 4);
            sequence.Remove(four);
            var seven = sequence.Where(p => p.SegmentCount == 3).First();
            digitPatterns.Add(seven, 7);
            sequence.Remove(seven);
            var eight = sequence.Where(p => p.SegmentCount == 7).First();
            digitPatterns.Add(eight, 8);
            sequence.Remove(eight);

            var nine = sequence.Where(p => p.SegmentCount == 6 && p.SharesAllSegmentsOf(four)).First();
            digitPatterns.Add(nine, 9);
            sequence.Remove(nine);
            var zero = sequence.Where(p => p.SegmentCount == 6 && p.SharesAllSegmentsOf(one) && p.SharesAllSegmentsOf(seven)).First();
            digitPatterns.Add(zero, 0);
            sequence.Remove(zero);
            var candidatesForSix = sequence.Where(p => p.SegmentCount == 6);
            if (candidatesForSix.Count() != 1) throw new Exception("Found more than one candidate for 6");
            var six = candidatesForSix.First();
            digitPatterns.Add(six, 6);
            sequence.Remove(six);

            var three = sequence.Where(p => p.SegmentCount == 5 && p.SharesAllSegmentsOf(one) && p.SharesAllSegmentsOf(seven)).First();
            digitPatterns.Add(three, 3);
            sequence.Remove(three);

            if (sequence.Count() != 2) throw new Exception("Too many numbers left to decode (2 & 5)");

            var bottomRightSegment = six.SharedSegments(one);

            var five = sequence.Where(p => p.SegmentCount == 5 && p.SharesAllSegmentsOf(bottomRightSegment)).First();
            digitPatterns.Add(five, 5);
            sequence.Remove(five);

            digitPatterns.Add(sequence.First(), 2);
        }

        public static int Count1478(string[] entries)
        {
            var patterns = entries.Select(e => SignalPattern.FromEntry(e));
            return patterns.Sum(p => p.CountEasyNumbersInOutput());
        }

        public static int OutputValueOf(string[] entries)
        {
            return entries.Sum(e => SignalPattern.FromEntry(e).OutputValue);
        }

        public int CountEasyNumbersInOutput()
        {
            var easyNumber = new int[] { 1, 4, 7, 8 };
            return output.Where(d => easyNumber.Contains(GetValue(d))).Count();
        }

        private int GetValue(Digit d)
        {
            Console.WriteLine($"Looking for '{d}' in Patterns: {string.Join(",", digitPatterns.Keys)}");
            if (!digitPatterns.Keys.Contains(d)) return -1;
            Console.WriteLine($"Found: {digitPatterns[d]}");
            return digitPatterns[d];
        }

        public class Digit : IEquatable<Digit>
        {
            private IEnumerable<char> segments;

            public Digit(string segments)
            {
                this.segments = segments.OrderBy(c => c);
            }

            public int SegmentCount
            {
                get
                {
                    return segments.Count();
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is Digit digit &&
                        Equals(digit);
            }

            public bool Equals(Digit? other)
            {
                return SegmentCount == other.SegmentCount &&
                       SharesAllSegmentsOf(other) &&
                       other.SharesAllSegmentsOf(this);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(SegmentCount, string.Join(",", segments));
            }

            public bool SharesAllSegmentsOf(Digit other)
            {
                return !other.segments.Except(this.segments).Any();
            }

            public Digit SharedSegments(Digit other)
            {
                var shared = other.segments.Intersect(this.segments);
                return new Digit(string.Join("", shared));
            }

            public override string? ToString()
            {
                return string.Join("", segments);
            }
        }
    }
}