
using System.Text.Json.Serialization;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Nile.API.Models;
using Mapster;
using Nile.API.Models.DTOs;
using Nile.lib;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// var config = new TypeAdapterConfig();
// config.NewConfig<Article, ArticleResponseDTO>()
//     .Map(dest => dest.ArticleId, src => src.ArticleId)
//     .Map(dest => dest.Title, src => src.Title)
//     .Map(dest => dest.Content, src => src.Content)
//     .Map(dest => dest.DatePublished, src => src.DatePublished)
//     .Map(dest => dest.AuthorName, src => src.Author.FirstName+ " "+src.Author.LastName);


builder.Services.AddDbContextPool<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DBConnection")));

builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IArticleRepository, ArticleRepository>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
// builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// builder.services.AddSwaggerGen(c => { c.SwaggerDoc("v1", 
//     new OpenApiInfo { Title = "My API", Version = "v1" }); 
//     c.ConflictingActionsResolver = apiDescriptions => apiDescriptions.First(); });

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
