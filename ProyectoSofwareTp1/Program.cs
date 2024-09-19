
using Application.Interfaces;
using Application.UseCase;
using Infraestructure;
using Infraestructure.Command;
using Infraestructure.Querys;
using Infraestructure.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//custom
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

//dependence
builder.Services.AddScoped<IClientServices, ClientsServices>();
builder.Services.AddScoped<IClientsQuery,ClientsQuery>();
builder.Services.AddScoped<IClientsCommand, ClientsCommand>();

builder.Services.AddScoped<IGenerateID, GuidGenerateServices>();

builder.Services.AddScoped<ICampaignTypeServices,CampaignTypesServices>();
builder.Services.AddScoped<ICampaignTypesQuery, CampaignTypesQuery>();
builder.Services.AddScoped<ICampaignTypesCommand, CampaignTypesCommand>();

builder.Services.AddScoped<IInteractionTypeServices, InteractionTypeServices>();
builder.Services.AddScoped<IInteractionTypeQuery, InteractionTypeQuery>();
builder.Services.AddScoped<IInteractionTypeCommand, InteractionTypeCommand>();

builder.Services.AddScoped<ITaskStatusServices, TaskStatusServices>();
builder.Services.AddScoped<ITaskStatusQuery, TaskStatusQuery>();
builder.Services.AddScoped<ITaskStatusCommand, TaskStatusCommand>();

builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddScoped<IUserQuery, UserQuery>();
builder.Services.AddScoped<IUserCommand, UserCommand>();


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
