var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); // Add controllers with views support

var app = builder.Build();
app.MapControllerRoute( // Add a default route for controllers "Home/Index/{id?}"
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


//app.MapGet("/", () => "Hello World!");

app.Run();
