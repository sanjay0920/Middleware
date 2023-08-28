
//creating instance of webapplication builder
var builder = WebApplication.CreateBuilder(args);

//creating instance of webapplication
var app = builder.Build();


//middleware1
app.Use(async(HttpContext context, RequestDelegate next) => //callback function
    {
        await context.Response.WriteAsync("Custom Middlewares");
        await next(context);

});
//middleware2
app.Use(async (HttpContext context, RequestDelegate next) => //callback function
{
    await context.Response.WriteAsync("\n\n");
    await next(context);

});
//middleware3
app.Run(async (HttpContext context) => //callback function
{
    await context.Response.WriteAsync("Welcome To Middleware Concepts!");

});
app.Run();