var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // Adds services for controllers and views to the DI container [Routing]

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

// custom MiddleWare | inline middleware | Can be used for logging, authentication, etc. but runs only at once (no multiple middlewares
//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Hello from custom middleware!");
//});

//// Convention based Routing
//app.MapDefaultControllerRoute(); // Sets up default routing for controllers
//app.MapControllerRoute(
//    name: "default", // You can set any name for the route
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//// Attribute based routing
app.MapControllers(); // Maps attribute-routed controllers

//// Middlewares
//app.Use(async (context, next) =>
//{
//    // Do something before the next middleware/component
//    await context.Response.WriteAsync("Hello from custom middleware - Before Next!\n");
//    await next(context); // Call the next middleware/component in the pipeline
//});

//app.Use(async (context, next) =>
//{
//    // Do something before the next middleware/component
//    await context.Response.WriteAsync("Hello from second middleware - After Next!\n");
//    await next(context); // Call the next middleware/component in the pipeline
//});

app.Run();  // Server starts and listens for requests
