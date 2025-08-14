
using Game.Interfaces;
using Game.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IGameService, GameService>();
builder.Services.AddScoped<IHelperApisService, HelperApisService>();
builder.Services.AddHttpClient<IHelperApisService, HelperApisService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder
                          .AllowAnyMethod()
                          .AllowAnyHeader()
                          .WithOrigins("http://localhost:3000", "https://localhost:3000")
                          .WithExposedHeaders("x-pagination")
                          );
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
