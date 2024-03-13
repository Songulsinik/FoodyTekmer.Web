using FoodyTekmerBusinessLayer.Abstract;
using FoodyTekmerBusinessLayer.Concrette;
using FoodyTekmerDataAccessLayer.Abstract;
using FoodyTekmerDataAccessLayer.AppDbContext;
using FoodyTekmerDataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IProductDal,EfProductDal>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<IAboutDal,EfAboutDal>();
builder.Services.AddScoped<IAboutService,AboutManager>();

builder.Services.AddScoped<IBlogDal,EfBlogDal>();
builder.Services.AddScoped<IBlogService,BlogManager>();

builder.Services.AddScoped<ICustomerReviewDal,EfCustomerReviewDal>();
builder.Services.AddScoped<ICustomerReviewService,CustomerReviewManager>();

builder.Services.AddScoped<IOurFeatureDal,EfOurFeatureDal>();
builder.Services.AddScoped<IOurFeatureService,OurFeatureManager>();

builder.Services.AddScoped<IVisitOurFirmDal,EfVisitOurFirmDal>();
builder.Services.AddScoped<IVisitOurFirmService,VisitOurFirmManager>();

builder.Services.AddScoped<IContactUsDal,EfContactUsDal>();
builder.Services.AddScoped<IContactUsService,ContactUsManager>();

builder.Services.AddDbContext<FoodyContext>();


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
