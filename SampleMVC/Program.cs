using Microsoft.EntityFrameworkCore;
using SampleMVC.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("studentportal")));

var app = builder.Build();


    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();   

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();



//_____________________________________________________________________________________________________
//    ********************************************sample code************************************

// This is the sample code for Run()
if (app.Environment.IsDevelopment())
{
    app.Run(async context =>
    {
        await context.Response.WriteAsync("Hello Readers!");
    });
}


//sample code for app.Use()
if (app.Environment.IsDevelopment())
{
    app.Use(async (context, next) => {
        await context.Response.WriteAsync($"Before Request {Environment.NewLine}");
        await next();
        await context.Response.WriteAsync($"After Request {Environment.NewLine}");
    });
}

//sample code for app.map()
// hence it is possible for us to map the different API by mention like below  
// each map function can have a run() response to run the page.

app.Map("/BranchOne", MapBranchOne);

app.Map("/BranchTwo", MapBranchTwo);

static void MapBranchOne(IApplicationBuilder app)
{
    app.Run(async context => {
        await context.Response.WriteAsync("You are on Branch One!");
    });
}
static void MapBranchTwo(IApplicationBuilder app)
{
    app.Run(async context => {
        await context.Response.WriteAsync("You are on Branch Two!");
    });
}