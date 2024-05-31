using ShippingCompanyContracts.Contracts;
using ShippingCompanyContracts.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<AppDbContext>();
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

// Endpoint contracts
app.AddEndpointsContracts();

app.Run();

