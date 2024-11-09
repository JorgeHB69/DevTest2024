using backend.Entities.Concretes;
using FluentValidation;
using Polls.Infrastructure.Context.Concretes;
using Polls.Infrastructure.Context.Interfaces;
using Polls.Infrastructure.Profiles;
using Polls.Infrastructure.Repositories.Concretes;
using Polls.Infrastructure.Repositories.Interfaces;
using Polls.Infrastructure.Validations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Repositories
builder.Services.AddScoped<IRepository<Poll>, PollRepository>();

// Context
builder.Services.AddSingleton<IContext<Poll>, OnMemoryContext>();

// Validators
builder.Services.AddValidatorsFromAssemblyContaining<PollValidator>();
builder.Services.AddSingleton<AbstractValidator<Poll>, PollValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<VoteValidator>();
builder.Services.AddSingleton<AbstractValidator<Vote>, VoteValidator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();