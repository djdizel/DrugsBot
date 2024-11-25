namespace Domain.Validators;

public static class ValidationMessage
{
    public static string NotNull = "{PropertyName} не может быть NULL}";
    public static string NotEmpty = "{PropertyName} не может быть empty}";
    public static string WrongLength = "{PropertyName} должен быть от {min} до {max} символов}";
    public const string RequiredField = "{PropertyName} обязательно для заполнения."; 
    public const string LengthField = "Длина {PropertyName} должна быть от {min} до {max} символов."; 
    public const string OnlyLettersDigitsAndSpaces = "{PropertyName} может содержать только буквы, цифры и пробелы."; 
    public const string OnlyLettersSpacesAndDashes = "{PropertyName} может содержать только буквы, пробелы и дефисы."; 
    public const string ExactLengthField = "{PropertyName} должно содержать ровно {length} символов."; 
    public const string OnlyUppercaseLetters = "{PropertyName} может содержать только заглавные буквы."; 
    public const string ValidCountryCode = "{PropertyName} должно содержать корректный код страны."; 
    public const string OnlyLettersAndSpaces = "{PropertyName} может содержать только буквы и пробелы."; 
    public const string OnlyLettersDigitsSpacesAndDashes = "{PropertyName} может содержать только буквы, цифры, пробелы и дефисы."; 
    public const string OnlyLettersDigitsAndDashes = "{PropertyName} может содержать только буквы, цифры и дефисы."; 
    public const string PositiveNumber = "{PropertyName} должно содержать положительное число."; 


}