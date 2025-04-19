namespace LibraryManagementAPI.Models;

using System.ComponentModel.DataAnnotations;

public class Login
{
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public required string Password { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (string.IsNullOrEmpty(UserName) && string.IsNullOrEmpty(Email))
        {
            yield return new ValidationResult(
                "Either UserName or Email must be provided.",
                new[] { nameof(UserName), nameof(Email) }
            );
        }
    }
}
