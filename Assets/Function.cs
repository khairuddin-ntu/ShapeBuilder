namespace ShapeBuilder
{
    public abstract record FunctionPart
    {
        protected string rawValue;

        public FunctionPart(char initialChar)
        {
            rawValue = initialChar.ToString();
        }

        protected void AddCharacter(char c)
        {
            rawValue += c;
        }
    }

    public abstract record ValuePart<T> : FunctionPart where T : unmanaged
    {
        public ValuePart(char initialChar) : base(initialChar) { }

        public abstract T GetValue();
    }

    public record IntPart : ValuePart<int>
    {
        public IntPart(char initialChar) : base(initialChar) { }

        public override int GetValue()
        {
            return IntUtils.ParseString(rawValue, int.MinValue);
        }
    }

    public record DecimalPart : ValuePart<double>
    {
        public DecimalPart(char initialChar) : base(initialChar) { }

        public override double GetValue()
        {
            return DoubleUtils.ParseString(rawValue, double.MinValue);
        }
    }
}
