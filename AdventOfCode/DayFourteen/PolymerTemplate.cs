namespace AdventOfCode.DayFourteen
{
    public class PolymerTemplate
    {
        private string value;

        public long CheckSum
        {
            get
            {
                var elementCount = value.GroupBy(v => v);
                var mostCommonElement = elementCount.OrderByDescending(grp => grp.Count()).First();
                var leastCommonElement = elementCount.OrderBy(grp => grp.Count()).First();
                return mostCommonElement.Count() - leastCommonElement.Count();
            }
        }

        public PolymerTemplate(string value)
        {
            this.value = value;
        }

        public int InsertionResult(string[] rules)
        {
            throw new NotImplementedException();
        }

        public PolymerTemplate Insert(PolymerRules rules)
        {
            return new PolymerTemplate(rules.Apply(this.value));
        }

        public PolymerTemplate Insert(PolymerRules rules, int steps)
        {
            var newPolymer = Insert(rules);
            if (steps <= 1) return newPolymer;
            else return newPolymer.Insert(rules, steps - 1);
        }

        public override bool Equals(object? obj)
        {
            return obj is PolymerTemplate template &&
                   value == template.value;
        }

        public override string? ToString()
        {
            return this.value;
        }
    }
}