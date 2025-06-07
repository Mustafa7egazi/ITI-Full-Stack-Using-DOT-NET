using System.ComponentModel.DataAnnotations;

namespace MvcCourseProject.Models.CustomAttributes
{
    public class DividedByThreeAttribute:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (int.Parse(value.ToString()) % 3 == 0)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Hours must be from 3 and it multiples");
            }
        }
    }
}
