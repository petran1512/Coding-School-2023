using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Fuel.Station.Blazor.Shared.Validator
{
    public class LettersValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            try
            {
                if (value != null)
                {
                    string? stringValue = value.ToString();
                    if(!Regex.IsMatch(stringValue, @"^[a-zA-Z]+$"))
                    {
                        return new ValidationResult(ErrorMessage ?? "The field must contain only Letters.");
                    }
                    return ValidationResult.Success;
                }
            }
            catch
            {

            }
            return new ValidationResult(ErrorMessage ?? "Please try again.");
        }
    }
}
