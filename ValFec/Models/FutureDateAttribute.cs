using System.ComponentModel.DataAnnotations;

namespace ValFec.Models;

public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        DateTime fecha = (DateTime)value;
        double fechaDecimal = fecha.ToOADate();
        int fechaEntero = (int)fecha.ToOADate();

        if (fechaEntero == 0 && fechaDecimal == 0)
        {
            return new ValidationResult("Proporcione una fecha");
        }

        if (fechaEntero == fechaDecimal && fecha > DateTime.Today)
        {
            return new ValidationResult("La fecha no puede ser mayor que la fecha actual");
        }
        else if (fechaEntero < fechaDecimal && fecha > DateTime.Now)
        {
            return new ValidationResult("La fecha y la hora no puede ser mayor que la fecha actual con su respectiva hora");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}


