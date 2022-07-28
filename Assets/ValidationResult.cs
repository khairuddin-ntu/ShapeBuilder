namespace ShapeBuilder
{
    public abstract record ValidationResult;

    public record Success : ValidationResult;

    public record Error(string ErrorMessage) : ValidationResult;
}
