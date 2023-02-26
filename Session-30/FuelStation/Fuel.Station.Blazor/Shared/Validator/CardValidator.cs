using Fuel.Station.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Fuel.Station.Blazor.Shared.Validator
{
    public class CardValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            try
            {
                if (value != null)
                {
                    string? stringValue = value.ToString();
                    if (!Regex.IsMatch("CardNumber", "CardNumber"))
                    {
                        return new ValidationResult(ErrorMessage ?? "The field can contain only Letter A.");
                    }
                    return ValidationResult.Success;
                }
            }
            catch
            {

            }
            return new ValidationResult(ErrorMessage ?? "This Card Number is already used try again.");
        }
    }
}
