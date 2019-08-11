using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Training.Model
{
    public class TrainingModel :IValidatableObject
    {
        [Required]
        public string TrainingName { get; set; }
        [Required]
        public string TrainingStartDate { get; set; }
        [Required]
        public string TrainingEndDate { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrEmpty(TrainingStartDate)){
                yield return new ValidationResult("Start date is not valid");
            }
            if (string.IsNullOrEmpty(TrainingEndDate))
            {
                yield return new ValidationResult("End date is not valid");
            }

            //If end date is before start date , throw an error.
            if (DateTime.Compare(DateTime.Parse(TrainingEndDate), DateTime.Parse(TrainingStartDate)) < 0)
            {
                yield return new ValidationResult("End date cannot be before the start date");
            }
        }
    }
}