namespace ShapeBuilder
{
    public abstract record FunctionPart { }

    public abstract record ValuePart<T> : FunctionPart where T : unmanaged
    {
        protected string rawValue;

        public ValuePart(char initialChar)
        {
            rawValue = initialChar.ToString();
        }

        public abstract T GetValue();

        protected void AddCharacter(char c)
        {
            rawValue += c;
        }
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
