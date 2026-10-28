namespace AuthApi.Api.Domain.ValueObjects;

public sealed record Password
{
    public string Value { get; private set; }

    public Password(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Password cannot be null or empty.", nameof(value));
        }

        Value = value;
    }

    public override string ToString() => "******";

}
