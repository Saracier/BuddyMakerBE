namespace API.DTO;

public class UserDto
{
    public required string Id {get; set;} = Guid.NewGuid().ToString();
    public required string DisplayName { get; set; }
    public required string Email { get; set; }
    public string? ImageUrl { get; set; }
    public required string Token { get; set; }
}