using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Station.Blazor.Shared.Avalidator 
{
    public class AValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            try
            {
                if (value != null)
                {
                    string? stringValue = value.ToString();
                    if (!stringValue.StartsWith("A"))
                    {
                        return new ValidationResult(ErrorMessage ?? "The field must start with the letter A.");
                    }
                    return ValidationResult.Success;
                }
            }
            catch
            {

            }
            return new ValidationResult(ErrorMessage ?? "Please type again your card number.");
        }
    }
}
