using Microsoft.EntityFrameworkCore;
using Nile.lib;

namespace Nile.API.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options) { }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Article> Articles { get; set; }
    public DbSet<Comment> Comments { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<Department>()
        //     .HasOne(d => d.Administrator)
        //     .WithMany()
        //     .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Department>().HasData(
            new Department { DepartmentId = 1, DepartmentName = "Sport" });
        modelBuilder.Entity<Department>().HasData(
            new Department { DepartmentId = 2, DepartmentName = "Bussness and Economy" });
        modelBuilder.Entity<Department>().HasData(
            new Department { DepartmentId = 3, DepartmentName = "Politics" });
        modelBuilder.Entity<Department>().HasData(
            new Department { DepartmentId = 4, DepartmentName = "Science and Tech" });

        modelBuilder.Entity<Author>().HasData(
            new Author
            {
                AuthorId = 1,
                FirstName = "Ali",
                LastName = "Sall",
                Email = "maxo@gmail.com",
                DateOfBirth = DateTime.Now,
                Gender = Gender.Male,
                DepartmentId = 4,
                Bio = "i'm jornalist and a former Software Engeer",
                PhotoPath = "img/a_7.jfif"
            });
        modelBuilder.Entity<Author>().HasData(
            new Author
            {
                AuthorId = 2,
                FirstName = "fatima ",
                LastName = "kane",
                Email = "fatima@gmail.com",
                DateOfBirth = DateTime.Now,
                Gender = Gender.Female,
                DepartmentId = 2,
                Bio = "i'm have Degree in busness and i am a writer",
                PhotoPath = "img/a_6jfif.jfif"
            });
        modelBuilder.Entity<Author>().HasData(
            new Author
            {
                AuthorId = 3,
                FirstName = "habib ",
                LastName = "Sall",
                Email = "habib@gmail.com",
                DateOfBirth = DateTime.Now,
                Gender = Gender.Male,
                DepartmentId = 3,
                Bio = "I'm a Writer who graduated from XbU with Polilic science Degree ",
                PhotoPath = "img/a_2.jfif"
            });
        modelBuilder.Entity<Author>().HasData(
            new Author
            {
                AuthorId = 4,
                FirstName = "Nancy ",
                LastName = "fay",
                Email = "maxo@gmail.com",
                DateOfBirth = DateTime.Now,
                Gender = Gender.Female,
                DepartmentId = 4,
                Bio = "i am a journalist with CS background",
                PhotoPath = "img/a_1.jfif"
            });
        modelBuilder.Entity<Author>().HasData(
            new Author
            {
                AuthorId = 5,
                FirstName = "nabou",
                LastName = "fall",
                Email = "nabou@gmail.com",
                DateOfBirth = DateTime.Now,
                Gender = Gender.Female,
                DepartmentId = 1,
                Bio = "I am a Sport Analyist and a writer",
                PhotoPath = "img/a_9.jfif"
            });
        modelBuilder.Entity<Author>().HasData(
            new Author
            {
                AuthorId = 6,
                FirstName = "Noora",
                LastName = "Disllo",
                Email = "nabou@gmail.com",
                DateOfBirth = DateTime.Now,
                Gender = Gender.Female,
                DepartmentId = 4,
                Bio = "I am a Jornalist who is intrested in tech and sciense",
                PhotoPath = "img/black_q.jpg"
            });
        modelBuilder.Entity<Author>().HasData(
            new Author
            {
                AuthorId = 7,
                FirstName = "Anwar",
                LastName = "Sadiq",
                Email = "nabou@gmail.com",
                DateOfBirth = DateTime.Now,
                Gender = Gender.Male,
                DepartmentId = 3,
                Bio = "I am polictic analysist",
                PhotoPath = "img/a_3.jfif"
            });
        modelBuilder.Entity<Author>().HasData(
            new Author
            {
                AuthorId = 8,
                FirstName = "Mansour",
                LastName = "Sall",
                Email = "Mansour@gmail.com",
                DateOfBirth = DateTime.Now,
                Gender = Gender.Male,
                DepartmentId = 3,
                Bio = "I am polictic analysist",
                PhotoPath = "img/a_3.jfif"
            });

    }
}
