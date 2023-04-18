var builder = WebApplication.CreateBuilder(args);
// var builder = WebApplication.CreateBuilder(new WebApplicationOptions(){
//     Args = args,
//     WebRootPath = "public"
// });

builder.Services.AddSingleton<SecondMiddleware>();

var app = builder.Build();

// StatusCodePages
app.UseStatusCodePages();

// Static File Middleware
// wwwroot
app.UseStaticFiles();

// app.UseMiddleware<FirstMiddleware>();
app.UseFirstMiddleware(); // Đưa vào pipeline FirstMiddleWare

app.UseSecondMiddleware();


// EndpointRoutingMiddleware
app.UseRouting(); // điều hướng request tới endpoint 


//  Tạo endpoints Terminate Middleware
app.UseEndpoints(endpoints => {
    endpoints.MapGet("/", async (context) => {
        string html = @"
                <!DOCTYPE html>
                <html>
                <head>
                    <meta charset=""UTF-8"">
                    <title>Trang web đầu tiên</title>
                    <link rel=""stylesheet"" href=""/css/bootstrap.min.css"" />
                    <script src=""/js/jquery.min.js""></script>
                    <script src=""/js/popper.min.js""></script>
                    <script src=""/js/bootstrap.min.js""></script>


                </head>
                <body>
                    <nav class=""navbar navbar-expand-lg navbar-dark bg-danger"">
                            <a class=""navbar-brand"" href=""#"">Brand-Logo</a>
                            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#my-nav-bar"" aria-controls=""my-nav-bar"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                                    <span class=""navbar-toggler-icon""></span>
                            </button>
                            <div class=""collapse navbar-collapse"" id=""my-nav-bar"">
                            <ul class=""navbar-nav"">
                                <li class=""nav-item active"">
                                    <a class=""nav-link"" href=""#"">Trang chủ</a>
                                </li>
                            
                                <li class=""nav-item"">
                                    <a class=""nav-link"" href=""#"">Học HTML</a>
                                </li>
                            
                                <li class=""nav-item"">
                                    <a class=""nav-link disabled"" href=""#"">Gửi bài</a>
                                </li>
                        </ul>
                        </div>
                    </nav> 
                    <p class=""display-4 text-danger"">Đây là trang đã có Bootstrap</p>
                </body>
                </html>
    ";
        await context.Response.WriteAsync(html);
    });

    endpoints.MapGet("/about", async (context) => {
        await context.Response.WriteAsync("Trang gioi thieu");
    });

    endpoints.MapGet("/contact", async (context) => {
        await context.Response.WriteAsync("Trang lien he");
    });
}); 

// Re nhanh trong pipeline
app.Map("/admin",app1 => {
    // Tao middleware cua nhanh
    app1.UseRouting();

    // BE1
    app1.UseEndpoints(endpoints => {
        endpoints.MapGet("/user",async(context) =>{
            await context.Response.WriteAsync("Trang quan ly user");
        });
    });

    // BE2
    app1.UseEndpoints(endpoints => {
        endpoints.MapGet("/product",async(context) =>{
            await context.Response.WriteAsync("Trang quan ly product");
        });
    });

    // M2
     app1.Run( async (context) => {
        await context.Response.WriteAsync("Trang admin");
    });
});

// Terminate middleware
// app.MapGet("/", () => "Hello World!");

// Terminate middleware
app.Map("/abc",app1 => {
    app1.Run( async (context) => {
        await context.Response.WriteAsync("Noi dung tra ve tu abc");
    });
});

//Terminate Middleware
// app.Run(async (HttpContext context) => {
//     await context.Response.WriteAsync("Hello"); 
// });

app.Run();