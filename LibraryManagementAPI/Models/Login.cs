namespace LibraryManagementAPI.Models;

using System.ComponentModel.DataAnnotations;

public class Login
{
    public string identifier { get; set; } = string.Empty;
    public required string Password { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (string.IsNullOrEmpty(identifier))
        {
            yield return new ValidationResult(
                "Either UserName or Email must be provided.",
                new[] { nameof(identifier) }
            );
        }
    }
}
