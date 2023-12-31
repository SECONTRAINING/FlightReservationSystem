using BusinessLogicLayer;
using DataAccessLayer;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//addded

var configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();
builder.Services.AddDbContext<FlightDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("FlightReservation")));
builder.Services.AddScoped<IBLLForAdmin, BLLForAdmin>();
builder.Services.AddScoped<IDALForAdmin, DALForAdmin>();
builder.Services.AddScoped<IBLLForFlightDetails, BLLForFlightDetails>();
builder.Services.AddScoped<IDALForFlightDetails, DALForFlightDetails>();
builder.Services.AddScoped<IBLLForFlightSchedule, BLLForFlightSchedule>();
builder.Services.AddScoped<IDALForFlightSchedule, DALForFlightSchedule>();
builder.Services.AddScoped<IBLLForUsers, BLLForUsers>();
builder.Services.AddScoped<IDALForUsers, DALForUser>();
//builder.Services.AddSession();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["Jwt:Audience"],
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
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
app.UseAuthentication();
app.MapControllers();

app.Run();
