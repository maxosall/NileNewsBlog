using Nile.Client;
using Nile.Client.Models;
using Nile.Client.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddAutoMapper(typeof(AuthorProfileMapper));

builder.Services.AddHttpClient<IAuthorService, AuthorService>(client =>
    client.BaseAddress = new Uri("https://localhost:7117/"));
builder.Services.AddHttpClient<IDepartmentService, DepartmentService>(client =>
    client.BaseAddress = new Uri("https://localhost:7117/"));
builder.Services.AddHttpClient<IArticleService, ArticleService>(client =>
    client.BaseAddress = new Uri("https://localhost:7117/"));
builder.Services.AddHttpClient<ICommentService, CommentService>(client =>
    client.BaseAddress = new Uri("https://localhost:7117/"));

// builder.Services.AddScoped(sp =>
//     new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
// builder.Services.AddSingleton<WeatherForecastService>();
// builder.Services.AddMemoryCache();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
