namespace GuapStalker.Common.Models;

/// <summary>
/// User model
/// </summary>
public class User
{
    public Ulid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public ICollection<Account> Accounts { get; set; } = new List<Account>();
}