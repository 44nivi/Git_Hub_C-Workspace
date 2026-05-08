using MVC_project_New;

using MVC_project_New.Configuration;
using MVC_project_New.Services;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<Middleware>();

builder.Services.Configure<BookStoreDatabaseSettings>(
builder.Configuration.GetSection("BookStoreDatabase"));
builder.Services.AddSingleton<BooksService>();

builder.Services.AddControllers()
    .AddJsonOptions(
        options => options.JsonSerializerOptions.PropertyNamingPolicy = null);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
};

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseMiddleware<Middleware>();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();



















/*app.MapEmployeeEndpoints();


//********************************************* Middle ware example to make the context active
app.UseAuthenticationMiddleware();   




//*************************************************pipeline example-1 for direct function

if (app.Environment.IsDevelopment())
{


    app.Use(async (context, next) =>
    {
        await context.Response.WriteAsync($"Before Request {Environment.NewLine}");
        await next();
        await context.Response.WriteAsync($"After Request {Environment.NewLine}");
    });
}




app.Map("/BranchOne", MapBranchOne);

app.Map("/BranchTwo", MapBranchTwo);

app.Map("/config", Configure);
static void MapBranchOne(IApplicationBuilder app)
{
    app.Run(async context =>
    {
        await context.Response.WriteAsync("You are on Branch One!");
    });
}
static void MapBranchTwo(IApplicationBuilder app)
{
    app.Run(async context =>
    {
        await context.Response.WriteAsync("You are on Branch Two!");
    });
}


//**********************************************pipeline example through direct function context
 void Configure(IApplicationBuilder app)
{
    app.Use(async (context, next) => Logic1(context,next));

    app.Use(async (context, next) => Logic2(context, next));

    app.Run(async (context) => Logic3(context));

}

  async Task Logic1(HttpContext obj ,Func<Task> next)
{
    await obj.Response.WriteAsync("this is logic1");
}

async Task Logic2(HttpContext obj, Func<Task> next)
{
    await obj.Response.WriteAsync("this is logic2");
}

async Task Logic3(HttpContext obj)
{
    await obj.Response.WriteAsync("this is logic3");
}*/

