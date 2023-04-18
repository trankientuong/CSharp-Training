using NETCOREMVC.Models;

var builder = WebApplication.CreateBuilder(args);

//Adding MVC Service. Framework Service
builder.Services.AddMvc();
// builder.Services.AddControllersWithViews();
//Application Service
builder.Services.AddSingleton<IStudentRepository, TestStudentRepository>();

var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

app.UseRouting();
app.UseStaticFiles();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    //Configuring the MVC middleware to the request processing pipeline
    endpoints.MapDefaultControllerRoute();
});

app.Run();
