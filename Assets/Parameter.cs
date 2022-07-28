namespace ShapeBuilder
{
    public struct Parameter
    {
        public string Label { get; }
        public int Min { get; }
        public int Max { get; }

        public Parameter(string label, int min, int max)
        {
            Label = label;
            Min = min;
            Max = max;
        }
    }
}
