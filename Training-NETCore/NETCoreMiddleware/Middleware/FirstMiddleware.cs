public class FirstMiddleware
{

    private readonly RequestDelegate _next;
    // RequestDelegate ~ async (HttpContext context) => {}
    public FirstMiddleware(RequestDelegate next)
    {
        _next = next;
    }


    // HttpContext đi qua Middleware trong pipeline
    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine($"URL: {context.Request.Path}");
        context.Items.Add("DataFirstMiddleware",$"<p>URL: {context.Request.Path}<p>");
        await _next(context);
    }
}