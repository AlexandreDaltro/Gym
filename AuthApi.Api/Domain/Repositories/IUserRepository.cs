using AuthApi.Api.Domain.Entities;
using AuthApi.Api.Domain.ValueObjects;

namespace AuthApi.Api.Domain.Repositories;

public interface IUserRepository
{
    Task<User?> GetByEmailAsync(Email email);
    Task AddAsync(User user);
}