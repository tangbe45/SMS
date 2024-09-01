using AcademiaPro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaPro.Domain.ValidationAttributes
{
    internal class Classroom_EnsureStudentCountNotGreaterThanCapacity : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var classroom = validationContext.ObjectInstance as Classroom;

            if (classroom != null)
            {
                if (!classroom.ValidateStudentCountNotGreaterThanCapacity())
                {
                    return new ValidationResult("StudentCount can not be greater than Capacity");
                }
            }
            else 
            {
                return new ValidationResult("Classroom can not be null");
            }
            
            return ValidationResult.Success;
        }
    }
}
