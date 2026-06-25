namespace BandHub.UserService.Features.Accounts.Domain;

public class Account
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public AccountType AccountType { get; set; }
    public DateTime CreatedAt { get; set; }
    public string? RefreshToken { get; set; } = string.Empty;
    public DateTime? RefreshTokenExpiraEm { get; set; }

    public Account()
    {
        Name = string.Empty;
        Email = string.Empty;
        PasswordHash = string.Empty;
    }

    public Account(string name, string email, string passwordHash, AccountType accountType, string? refreshToken = null, DateTime? refreshTokenExpiraEm = null)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
        AccountType = accountType;
        CreatedAt = DateTime.UtcNow;
        RefreshToken = refreshToken;
        RefreshTokenExpiraEm = refreshTokenExpiraEm;
    }
}
