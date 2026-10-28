namespace AuthApi.Api.Domain.ValueObjects;

public sealed record PasswordHash
{
    public string Value { get; private set; }

    public PasswordHash(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Password hash cannot be null or empty.", nameof(value));
        }

        Value = value;
    }
}
