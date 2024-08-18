using Microsoft.EntityFrameworkCore;
 
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using EntityFrameWork.E_CommerceProject.DbContextECommerceProject;
using Microsoft.AspNetCore.Hosting;
 using EntityFrameWork.E_CommerceProject;
using ApplicationService.E_CommerceProject;
using EcommerceProject.Core;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var ecommerce = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(ecommerce));

 
builder.Services.AddControllers();
//builder.Services.AddAutoMapper(typeof(Program));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/////////////////////////////
///
#region Dependencies Inhection
builder.Services.AddInfrastrctreDependencies()
                .AddServiceDependencies()
                .AddCoreDependencies();
#endregion



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<ApplicationDbContext>();
    context.Database.EnsureCreated();
 }

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
