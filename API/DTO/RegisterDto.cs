using System.ComponentModel.DataAnnotations;

namespace API.DTO;

public class RegisterDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }= "";
    [Required]
    public string DisplayName { get; set; }= "";
    [Required]
    [MinLength(5)]
    public string Password { get; set; }= "";
}