using System.ComponentModel.DataAnnotations;

namespace ZadaniaRekrutacyjne.Utility
{
    public class IfNumberSplitedStringAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var numbersString = value as string;
            if (numbersString != null)
            {
                if (numbersString.Contains(','))
                {
                    var numbersStringSplited = numbersString.Split(',');
                    foreach (var number in numbersStringSplited)
                    {
                        int outPutInt;
                        if (!int.TryParse(number.ToString(), out outPutInt))
                        {
                            return new ValidationResult("Incorect input numbers");
                        }
                    }
                            return ValidationResult.Success;
                }
                else
                {
                    int number;
                    if (int.TryParse(numbersString, out number))
                    { 
                    return ValidationResult.Success;
                    }
                    else
                    {
                        return new ValidationResult("Incorect input number");
                    }
                }
            }
            else
            {
                return new ValidationResult("Input cant be null");
            }
        }
    }
}
