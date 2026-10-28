using AuthApi.Api.Infrastructure.Persistence.Documents;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

var client = new MongoClient("mongodb://localhost:27017");

var database = client.GetDatabase("AuthApiDb");
var collection = database.GetCollection<UserDocument>("users");
collection.InsertOne(new UserDocument
{
    Id = Guid.NewGuid(),
    Email = "teste@email.com",
    PasswordHash = "123456"
});
app.Logger.LogInformation("Usuário inserido no MongoDB com sucesso!");

app.Run();
