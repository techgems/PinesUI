using AspNetStatic;
using AspNetStaticContrib.AspNetStatic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSingleton<IStaticResourcesInfoProvider>(
   new StaticResourcesInfoProvider()
     .AddAllProjectRazorPages(builder.Environment)
     .AddAllWebRootContent(builder.Environment));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

//app.GenerateStaticContent(@"C:\PinesUI Static");
app.Run();
