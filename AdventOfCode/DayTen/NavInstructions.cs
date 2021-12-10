namespace AdventOfCode.DayTen
{
    public class NavInstructions
    {
        private readonly Dictionary<char, int> POINTS;

        private readonly Dictionary<char, double> COMPLETION_POINTS;
        private string[] input;

        public NavInstructions(string[] input)
        {
            this.input = input;

            POINTS = new Dictionary<char, int>();
            POINTS.Add(')', 3);
            POINTS.Add(']', 57);
            POINTS.Add('}', 1197);
            POINTS.Add('>', 25137);

            COMPLETION_POINTS = new Dictionary<char, double>();
            COMPLETION_POINTS.Add(')', 1);
            COMPLETION_POINTS.Add(']', 2);
            COMPLETION_POINTS.Add('}', 3);
            COMPLETION_POINTS.Add('>', 4);
        }

        public int SyntaxErrorScore
        {
            get
            {
                var score = 0;
                foreach (var line in input)
                {
                    var illegalChar = HasIllegalSyntax(line);
                    if (illegalChar != null)
                    {
                        score += POINTS[illegalChar.Value];
                    }
                }
                return score;
            }
        }

        private char? HasIllegalSyntax(string line)
        {
            var stack = new List<char>();
            foreach (char brace in line)
            {
                if (brace == ')')
                {
                    {
                        if (stack.Last() != '(') return brace;
                        stack.RemoveAt(stack.Count() - 1);
                    }
                }
                else if (brace == ']')
                {
                    {
                        if (stack.Last() != '[') return brace;
                        stack.RemoveAt(stack.Count() - 1);
                    }
                }
                else if (brace == '}')
                {
                    {
                        if (stack.Last() != '{') return brace;
                        stack.RemoveAt(stack.Count() - 1);
                    }
                }
                else if (brace == '>')
                {
                    {
                        if (stack.Last() != '<') return brace;
                        stack.RemoveAt(stack.Count() - 1);
                    }
                }
                else
                {
                    stack.Add(brace);
                }
            }
            return null;
        }

        public double CompletionScore
        {
            get
            {
                var scores = new List<double>();
                foreach (var line in input)
                {
                    var completionChars = CompletionChars(line);
                    if (completionChars != String.Empty)
                    {
                        Console.WriteLine($"Completion String: {completionChars}");
                        double score = 0;
                        foreach (char c in completionChars)
                        {
                            score = (score * 5.0) + COMPLETION_POINTS[c];
                        }
                        scores.Add(score);
                    }
                }
                scores.Sort();
                Console.WriteLine($"Scores: {string.Join(",", scores)}");
                return scores.Skip(scores.Count() / 2).First();
            }
        }

        private string CompletionChars(string line)
        {
            var stack = new List<char>();
            foreach (char brace in line)
            {
                if (brace == ')')
                {
                    {
                        if (stack.Last() != '(') return String.Empty;
                        stack.RemoveAt(stack.Count() - 1);
                    }
                }
                else if (brace == ']')
                {
                    {
                        if (stack.Last() != '[') return String.Empty;
                        stack.RemoveAt(stack.Count() - 1);
                    }
                }
                else if (brace == '}')
                {
                    {
                        if (stack.Last() != '{') return String.Empty;
                        stack.RemoveAt(stack.Count() - 1);
                    }
                }
                else if (brace == '>')
                {
                    {
                        if (stack.Last() != '<') return String.Empty;
                        stack.RemoveAt(stack.Count() - 1);
                    }
                }
                else
                {
                    stack.Add(brace);
                }
            }

            stack.Reverse();
            var completeWith = "";
            foreach (var c in stack)
            {
                switch (c)
                {
                    case '(':
                        completeWith += ")";
                        break;
                    case '[':
                        completeWith += "]";
                        break;
                    case '{':
                        completeWith += "}";
                        break;
                    case '<':
                        completeWith += ">";
                        break;
                }
            }
            return completeWith;
        }
    }
}