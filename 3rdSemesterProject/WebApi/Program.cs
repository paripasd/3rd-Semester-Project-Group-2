using Microsoft.Extensions.DependencyInjection;
using WebApi.DataAccessLayer;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager _configuration = builder.Configuration;


// Add services to the container.
builder.Services.AddScoped<IDeveloperDataAccess>((conf) => new DeveloperDataAccess(_configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IGameDataAccess>((conf) => new GameDataAccess(_configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IEventDataAccess>((conf) => new EventDataAccess(_configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IMemberDataAccess>((conf) => new MemberDataAccess(_configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ILoginDataAccess>((conf) => new LoginDataAccess(_configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ISaleDataAccess>((conf) => new SaleDataAccess(_configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IEventMemberDataAccess>((conf) => new EventMemberDataAccess(_configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IGameFileDataAccess>((conf) => new GameFileDataAccess(_configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
