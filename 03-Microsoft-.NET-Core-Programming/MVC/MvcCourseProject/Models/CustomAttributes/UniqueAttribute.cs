using MvcCourseProject.Models.DBModels;
using MvcCourseProject.Repository;
using System.ComponentModel.DataAnnotations;

namespace MvcCourseProject.Models.CustomAttributes
{
    public class UniqueAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            // Get the repository from the service provider
            var courseRepo = (ICourseRepository?)validationContext.GetService(typeof(ICourseRepository));

            if (courseRepo == null)
            {
                throw new InvalidOperationException("ICourseRepository is not available in the validation context.");
            }

            // Get the full object instance being validated
            Course courseFromContext = (Course)validationContext.ObjectInstance;

            // Check if course already exists
            var courseFromDb = courseRepo.GetCourseByNameAndDeptId(value?.ToString(), courseFromContext.DepartmentId);

            if (courseFromDb == null)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult($"Course with name {value} already exists in this department.");
            }
        }
    }
}
