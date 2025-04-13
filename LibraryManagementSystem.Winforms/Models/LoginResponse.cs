namespace LibraryManagementSystem.Winforms.Models;

public class LoginResponse
{
    public string Token { get; set; }
    public int ExpiresIn { get; set; }
}