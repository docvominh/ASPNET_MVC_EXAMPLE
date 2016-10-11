using System;
using System.ComponentModel.DataAnnotations;

namespace MONGO_CONNECT.CustomValidation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class CustomRequiredAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("" + validationContext.DisplayName + " is fucking required");
            }
        }
    }
}