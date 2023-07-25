using FactoryInjection.Factories;
using FactoryInjection.Services.Parts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPartFactory, PartFactory>();
builder.Services.AddScoped<PublicPartService>()
    .AddScoped<IPartService, PublicPartService>(p => p.GetService<PublicPartService>());
builder.Services.AddScoped<PrivatePartService>()
    .AddScoped<IPartService, PrivatePartService>(p => p.GetService<PrivatePartService>());

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
