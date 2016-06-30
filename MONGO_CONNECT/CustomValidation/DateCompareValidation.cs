using System;
using System.ComponentModel.DataAnnotations;

namespace MONGO_CONNECT.CustomValidation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class DateCompareValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                int currentYear = DateTime.Now.Year;

                int inputYear = Convert.ToDateTime(value).Year;

                if (currentYear - inputYear < 18)
                {
                    return new ValidationResult("" + validationContext.DisplayName + " not enough age");
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            else
            {
                return new ValidationResult("" + validationContext.DisplayName + " is required");
            }
        }
    }
}