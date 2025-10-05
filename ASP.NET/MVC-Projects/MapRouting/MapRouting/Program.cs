var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Routing & Endpoints -- Method
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/RETRIEVE", async (context) =>
    {
        await context.Response.WriteAsync("Hello World! - GET");
    });

    endpoints.MapPost("/CREATE", async (context) =>
    {
        await context.Response.WriteAsync("Hello World! - POST");
    });
    
    endpoints.MapPut("/UPDATE", async (context) =>
    {
        await context.Response.WriteAsync("Hello World! - PUT");
    });
    
    endpoints.MapDelete("/DELETE", async (context) =>
    {
        await context.Response.WriteAsync("Hello World! - DELETE");
    });
    
    endpoints.Map("/ANY", async (context) =>
    {
        await context.Response.WriteAsync("Hello World! - ANY");
    });
});

//// Map for any HTTP method
//app.Map("/any", () => "Hello World! - ANY");

//// Map for specific HTTP methods
//app.MapGet("/", () => "Hello World! - GET");
//app.MapPost("/", () => "Hello World! - POST");
//app.MapPut("/", () => "Hello World! - PUT");
//app.MapDelete("/", () => "Hello World! - DELETE");

app.Run();
