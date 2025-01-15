var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseFileServer();

app.UseRouting();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

/*
//Middleware that Goes to error.html whenever there is an error
//It shows the detailed error by default but we should show uses smth nice
// if "ASPNETCORE_ENVIRONMENT": "Production", this will show
app.UseExceptionHandler("/error.html");

//Middleware that presents a more detailed error message

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}


app.UseFileServer();

app.Use(async (context, next) =>
{
    if (context.Request.Path.Value.Contains("invalid"))
    {
        throw new Exception("ERROR!");
    }
    await next();
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("<h1>Hello from Use</h1>");
    await next();
    await context.Response.WriteAsync("<h1>Hello again from Use</h1>");
});

app.Run(async context => await context.Response.WriteAsync("<h1>Hello from Run</h1>"));
*/
app.Run();