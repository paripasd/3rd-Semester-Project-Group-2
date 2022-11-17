using WebApi.DataAccessLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IDeveloperDataAccess, DeveloperDataAccess>();
builder.Services.AddScoped<IGameDataAccess, GameDataAccess>();
builder.Services.AddScoped<IEventDataAccess, EventDataAccess>();
builder.Services.AddScoped<IMemberDataAccess, MemberDataAccess>();
builder.Services.AddScoped<ILoginDataAccess, LoginDataAccess>();
builder.Services.AddScoped<ISaleDataAccess, SaleDataAccess>();

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
