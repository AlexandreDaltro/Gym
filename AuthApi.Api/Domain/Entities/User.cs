using AuthApi.Api.Domain.ValueObjects;

namespace AuthApi.Api.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public Email Email { get; private set; }
    public PasswordHash PasswordHash { get; private set; }

    public User(Email email, PasswordHash passwordHash, Guid? id = null)
    {
        Id = id ?? Guid.NewGuid();
        Email = email ?? throw new ArgumentNullException(nameof(email));
        PasswordHash = passwordHash ?? throw new ArgumentNullException(nameof(passwordHash));
    }
}
