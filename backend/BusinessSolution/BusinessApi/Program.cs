var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// everything above here is configuring the "guts" of teh API
var app = builder.Build();
//everything after here is sertting up the Request/Response pipeline

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/clock", () =>
{
    var response = new GetClockResponse(true, null);

    return Results.Ok(response);
});

// Start the Web Server (Kestrel)
app.Run();

public record GetClockResponse(bool IsOpen, DateTime? NextOpenTime);