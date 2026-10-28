using AuthApi.Api.Domain.Repositories;
using IMongoDatabase = MongoDB.Driver.IMongoDatabase;
using AuthApi.Api.Domain.Entities;
using AuthApi.Api.Domain.ValueObjects;

public class UserRepository :IUserRepository
{
    private UserRepository(IMongoDatabase database)
    {
    }

    public Task<User?> GetByEmailAsync(Email email)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(User user)
    {
        throw new NotImplementedException();
    }
}