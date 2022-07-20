abstract record ValidationResult;

record Success : ValidationResult;

record Error(string ErrorMessage) : ValidationResult;