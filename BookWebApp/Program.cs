var builder = WebApplication.CreateBuilder(args);
foreach (var arg in args)
{
    Console.WriteLine(arg);
}
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.Use(async (context, next) =>
{
    // Do work that can write to the Response.
    Console.WriteLine("RequestPath: " + context.Request.Path);

    await next.Invoke();
    // Do logging or other work that doesn't write to the Response.
});


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
