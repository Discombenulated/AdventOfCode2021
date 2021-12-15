using System.Collections;

namespace AdventOfCode.DayFourteen
{
    public class PolymerRules : Dictionary<string, string>
    {
        private readonly string NOTHING_TO_INSERT = string.Empty;
        private Dictionary<string, string> rules;

        public PolymerRules(string[] rules)
        {
            this.rules = new Dictionary<string, string>();
            foreach (var rule in rules)
            {
                var r = rule.Split(" -> ");
                var pattern = r[0];
                var insertElement = r[1];
                this.rules.Add(pattern, insertElement);
            }
        }

        public string Apply(string polymer)
        {
            var result = "";
            for (int i = 0; i < polymer.Length - 1; i++)
            {
                var elementPair = string.Join("", polymer.Skip(i).Take(2));
                if (rules.ContainsKey(elementPair))
                {
                    result += polymer[i] + rules[elementPair];
                }
                else
                {
                    result += polymer[i];
                }
            }
            result += polymer.Last();
            return result;
        }
    }
}