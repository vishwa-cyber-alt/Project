////using WebApplication2.Repositories;

////var builder = WebApplication.CreateBuilder(args);

////// Register the repository interface and implementation with dependency injection
////builder.Services.AddScoped<IUserRepo, UserRepo>();

////// Add services to the container.
////builder.Services.AddControllersWithViews();

////var app = builder.Build();

////// Configure the HTTP request pipeline.
////if (app.Environment.IsDevelopment())
////{
////    app.UseDeveloperExceptionPage();
////}
////else
////{
////    app.UseExceptionHandler("/Home/Error");
////    app.UseHsts();
////}

////app.UseHttpsRedirection();
////app.UseStaticFiles();

////app.UseRouting();

////app.MapControllerRoute(
////    name: "default",
////    pattern: "{controller=Home}/{action=Index}/{id?}");

////app.Run();
////var builder = WebApplication.CreateBuilder(args);

////// Add CORS policy to allow all origins (or specify allowed origins)
////builder.Services.AddCors(options =>
////{
////    options.AddPolicy("AllowAllOrigins", policy =>
////    {
////        policy.AllowAnyOrigin() // Allow requests from any origin
////              .AllowAnyMethod()  // Allow any HTTP method (GET, POST, etc.)
////              .AllowAnyHeader(); // Allow any headers
////    });
////});

////// Add services to the container.
////builder.Services.AddControllersWithViews();

////var app = builder.Build();

////// Use CORS middleware
////app.UseCors("AllowAllOrigins");

////app.UseRouting();
////app.MapControllers(); // Make sure controllers are mapped

////app.Run();
//var builder = WebApplication.CreateBuilder(args);

//// Add CORS policy to allow the frontend origin
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowFrontendOrigin",
//        policy =>
//        {
//            policy.WithOrigins("http://127.0.0.1:5500")  // Adjust this if you're running the frontend on a different port
//                  .AllowAnyMethod()
//                  .AllowAnyHeader();
//        });
//});

//// Add services to the container.
//builder.Services.AddControllers();

//var app = builder.Build();

//// Use CORS middleware
//app.UseCors("AllowFrontendOrigin");

//app.UseRouting();
//app.MapControllers();

//app.Run();
//var builder = WebApplication.CreateBuilder(args);

//// Add CORS policy to allow all origins without credentials
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowAllOriginsNoCredentials",
//        policy =>
//        {
//            policy.AllowAnyOrigin()   // Allow all origins
//                  .AllowAnyMethod()   // Allow any HTTP method (GET, POST, etc.)
//                  .AllowAnyHeader();  // Allow any headers
//        });
//});

//// Add services to the container.
//builder.Services.AddControllers();

//var app = builder.Build();

//// Use CORS middleware with the "AllowAllOriginsNoCredentials" policy before routing
//app.UseCors("AllowAllOriginsNoCredentials");

//app.UseRouting();
//app.MapControllers();

//app.Run();
using WebApplication2.Models;
using WebApplication2.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add CORS policy (replace with specific frontend URL for production)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontendOrigin", policy =>
    {
        policy.WithOrigins("http://127.0.0.1:5500")  // Replace with your frontend URL
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// Register repository interface and implementation with dependency injection
builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<ICredentialsRepo, CredentialsRepo>();



// Add services to the container
builder.Services.AddControllers();

var app = builder.Build();

// Use CORS middleware with the "AllowFrontendOrigin" policy before routing
app.UseCors("AllowFrontendOrigin");

app.UseRouting();
app.MapControllers();

app.Run();
