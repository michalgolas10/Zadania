using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace ZadaniaRekrutacyjne.Utility
{
    public class IfMatrixIsCorrectAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var input = value as string;
                if (input.Contains(','))
                {
                var listOfLenghtsOfMatrixRows = new List<int>();
                    var splitedInput = input.Split(',');
                    foreach(var rowInMatrix in splitedInput)
                {
                    listOfLenghtsOfMatrixRows.Add(rowInMatrix.Length);
                }
                var maxRowLenght = listOfLenghtsOfMatrixRows.Max();
                if (listOfLenghtsOfMatrixRows.Any(x => x < maxRowLenght))
                {
                    return new ValidationResult("Wrong input matrix");
                }
                else
                {
                    return ValidationResult.Success;
                }
                }
            else
            {
                    return ValidationResult.Success;
            }
            
        }
    }
}
