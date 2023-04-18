public class SecondMiddleware : IMiddleware
{
    /*
        Url : /xxx.html
            - Khong goi middlware phia sau
            - Header - SecondMiddleware : Ban khong duoc truy cap
        Url: != "/xxx.hmtl"
            - Header - SecondMiddleware : Ban duoc truy cap
            - Chuyen HttpContext cho Middlware phia sau
    */

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        if (context.Request.Path == "/xxx.html")
        {
            context.Response.Headers.Add("SecondMiddleware","Ban khong duoc truy cap");
            var datafromFirstMiddleware = context.Items["DataFirstMiddleware"];
            if(datafromFirstMiddleware != null){
                await context.Response.WriteAsync((string)datafromFirstMiddleware);
            }
            await context.Response.WriteAsync("Ban khong duoc truy cap");
        }
        else
        {
            context.Response.Headers.Add("SecondMiddleware","Ban duoc truy cap");
            var datafromFirstMiddleware = context.Items["DataFirstMiddleware"];
            if(datafromFirstMiddleware != null){
                await context.Response.WriteAsync((string)datafromFirstMiddleware);
            }
            await next(context);
        }
    }
}