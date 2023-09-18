using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Utility
{
    public class IfStringIsNumberAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var numberString = value as string;
            if(numberString != null)
            {
                int number;
                if(!int.TryParse(numberString,out number)) 
                {
                    return new ValidationResult("Mordo to nie numer");
                }
            }
            return ValidationResult.Success;
        }
    }
}
