using LoanAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddScoped<IRateService, RateService>();

// Add controller
builder.Services.AddControllers();

// Adding swagger I hear this is good documentation and api list
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// if in development environment enable swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
