namespace ShapeBuilder
{
    public abstract record FunctionPart { }

    public abstract record ParameterPart : FunctionPart
    {
        public string ParamName { get; }

        public ParameterPart(char paramName)
        {
            ParamName = paramName.ToString();
        }
    }

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

    public abstract record OperationPart : FunctionPart { }

    public record PlusOperationPart : OperationPart { }

    public record MinusOperationPart : OperationPart { }

    public record MultiplyOperationPart : OperationPart { }

    public record DivideOperationPart : OperationPart { }
}
