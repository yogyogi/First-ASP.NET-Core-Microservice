using CommandCenter.Entity;
using CommandCenter.MongoDB;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMongo().AddMongoRepository<Order>("pizzaItems");
builder.Services.AddControllers(options =>
{
    options.SuppressAsyncSuffixInActionNames = false;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();