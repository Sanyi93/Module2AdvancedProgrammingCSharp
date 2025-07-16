var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.Map("/", async context =>

    //Auslesen des ConfigurationKeys
    {
        await context.Response.WriteAsync(app.Configuration["VarKey"]);
    });
});

//app.MapGet("/", () => "Hello World!");

app.Run();
