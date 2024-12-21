using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.EntityFrameworkCore;
using Dal;
using Bll;
using dal.models1;
using dto;
using dal;


var builder = WebApplication.CreateBuilder(args);
//db tabels
//-- product ----------------------------------------------------------
builder.Services.AddScoped(typeof(IProductDal), typeof(ProductDal));
builder.Services.AddScoped(typeof(IProductBll), typeof(ProductBll));
//-- Category ----------------------------------------------------------
//builder.Services.AddScoped(typeof(ICategoryBll), typeof(CategoryBll));
//builder.Services.AddScoped(typeof(ICategoryDal), typeof(CategoryDal));
////-- Customer ----------------------------------------------------------
builder.Services.AddScoped(typeof(ICustomerBll), typeof(CustomerBll));
builder.Services.AddScoped(typeof(ICustomerDal), typeof(CustomerDal));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddDbContext<dal.models1.Angular1Context>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//connect to angular
builder.Services.AddCors(o =>
{
    o.AddPolicy("CorsPolicy",
        builder =>
        {
            builder
            .WithOrigins("http://localhost:4200")
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
});

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//conect to angular
app.UseCors("CorsPolicy");

app.Run();



