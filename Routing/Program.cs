var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.Map("/Home", async (context) =>
    {
        await context.Response.WriteAsync("You are in HOME page");
    });

    endpoints.MapGet("/Product", async (context) =>
    {
        await context.Response.WriteAsync("You are in PRODUCT page");
    });

    endpoints.MapPost("/Product", async (context) =>
    {
        await context.Response.WriteAsync("You are in PRODUCT created page");
    });
});

app.Run(async(HttpContext context) =>
{
    await context.Response.WriteAsync("Page not found");
});

app.Run();
