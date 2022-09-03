using FluentValidation;
using MediatR;
using MongoDB.Driver;
using TerraMart.Data;
using TerraMart.Domain;
using TerraMart.Domain.Validators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Configure mongodb
builder.Services.AddSingleton(provider => builder.Configuration.GetSection(nameof(MongoDbConfig)).Get<MongoDbConfig>());
builder.Services.AddSingleton<IMongoClient>(provider =>
{
    var connectionString = provider.GetService<MongoDbConfig>()?.ConnectionString ?? throw new ArgumentException("Invalid mongo-db config: connection string not found!");
    return new MongoClient(connectionString);
});
builder.Services.AddScoped<IMongoDbContext, MongoDbContext>();
builder.Services.AddScoped(typeof(IMongoDbContext<>), typeof(MongoDbContext<>));
builder.Services.AddMediatR(typeof(Program), typeof(IMongoDbContext), typeof(Entity));
builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
builder.Services.AddValidatorsFromAssembly(typeof(Entity).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
