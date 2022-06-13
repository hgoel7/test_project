using Cymax_API_test.ApiConsumers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient<Service1Consumer>(c =>
{
    c.BaseAddress = new Uri("https://service1.com/");
    // Github API versioning
    c.DefaultRequestHeaders.Add("Accept", "application/json");
});

builder.Services.AddHttpClient<Service2Consumer>(c =>
{
    c.BaseAddress = new Uri("https://service2.com/");
    // Github API versioning
    c.DefaultRequestHeaders.Add("Accept", "application/json");
});

builder.Services.AddHttpClient<Service3Consumer>(c =>
{
    c.BaseAddress = new Uri("https://service3.com/");
    // Github API versioning
    c.DefaultRequestHeaders.Add("Accept", "application/xml");
});


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

