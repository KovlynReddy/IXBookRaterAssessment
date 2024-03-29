using IXBookApi.Data;
using IXBookApi.Data.Interface;
using IXBookApi.Data.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<BookRatingDBContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddScoped<IBookRepo, BookRepo>();
builder.Services.AddScoped<IRatingRepo, RatingRepo>();

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

//app.UseAuthorization();
app.UseRouting();
app.MapControllers();

app.Run();
