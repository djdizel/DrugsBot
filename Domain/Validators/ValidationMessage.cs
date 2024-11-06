namespace Domain.Validators;

public static class ValidationMessage
{
    public static string NotNull = "{PropertyName} не может быть NULL}";
    public static string NotEmpty = "{PropertyName} не может быть empty}";
    public static string WrongLength = "{PropertyName} должен быть от {min} до {max} символов}";

}