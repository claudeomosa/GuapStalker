using api.Queries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services
    .AddGraphQLServer()
    .AddQueryType<UserQuery>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapGraphQL();

}

app.UseHttpsRedirection();

app.UseAuthorization();

//app.MapControllers();

app.Run();
