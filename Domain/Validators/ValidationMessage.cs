namespace Domain.Validators;

public static class ValidationMessage
{
    public static string NotNull = "{PropertyName} не может быть NULL}";
    public static string NotEmpty = "{PropertyName} не может быть empty}";
    public static string WrongLength = "{PropertyName} должен быть от {min} до {max} символов}";
    public const string RequiredField = "Field is required.";
    public const string LengthField = "Field must be between 2 and 150 characters.";
    public const string OnlyLettersDigitsAndSpaces = "Field must contain only letters, digits, and spaces.";
    public const string OnlyLettersSpacesAndDashes = "Field is required.";
    public const string ExactLengthField = "Field is required.";
    public const string OnlyUppercaseLetters = "Field is required.";
    public const string ValidCountryCode = "Field is required.";
    public const string OnlyLettersAndSpaces = "Field must contain only letters, digits, and spaces.";
    public const string OnlyLettersDigitsSpacesAndDashes = "Field must contain only letters, digits, and spaces.";
    public const string OnlyLettersDigitsAndDashes = "Field must contain only letters, digits, and spaces.";
    public const string PositiveNumber = "Field must contain only letters, digits, and spaces.";

}