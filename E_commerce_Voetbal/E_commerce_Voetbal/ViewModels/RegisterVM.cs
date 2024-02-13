using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_commerce_Voetbal.ViewModels
{

    /**
     * Custom validator voor geboortedatum
     */
    public class DateOfBirthAtrribute : ValidationAttribute
    { 
    
        public string GetErrorMessage() => $"Je moet minstens 18 jaar oud zijn.";

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var person = (RegisterVM)validationContext.ObjectInstance;

            if((DateTime.Now.Date - person.Geboortedatum.Value.Date).Days / 365 < 18)
            {
                return new ValidationResult(GetErrorMessage());
            }
           
            return ValidationResult.Success;
        }
    }

    /**
     * Custom validator voor het bevestigde wachtwoord
     */
    public class PasswordConfirmAttribute : ValidationAttribute {

        public string GetErrorMessage() => $"Het wachtwoord correspondeert niet met het ingevulde wachtwoord.";

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var person = (RegisterVM)validationContext.ObjectInstance;

            if (!person.Wachtwoord.Equals(person.ConfirmPassword))
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }
    }

    /**
     * ViewModel dat dient voor te registeren
     */
    public class RegisterVM
    {
        [Required(ErrorMessage = "Naam moet gegeven worden")]
        public string? Naam { get; set; }

        [Required (ErrorMessage = "Voornaam moet gegeven worden")]
        public string? Voornaam { get; set; }

        [Required (ErrorMessage = "Emailadres moet gegeven worden")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [RegularExpression(@"[\w\W]{8,}", ErrorMessage = "Wachtwoord moet minstens 8 karakters lang zijn.")]
        public string? Wachtwoord { get; set; }

        [Display(Name = "Bevestig wachtwoord")]
        [Required]
        [PasswordConfirmAttribute()]
        public string? ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Geboortedatum moet ingevuld zijn")]
        [DataType(DataType.Date)]
        [DateOfBirthAtrribute()]
        public DateTime? Geboortedatum { get; set; }

    }
}
