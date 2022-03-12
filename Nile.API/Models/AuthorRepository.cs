using Microsoft.EntityFrameworkCore;
using Nile.lib;

namespace Nile.API.Models;

public class AuthorRepository : IAuthorRepository
{
    private readonly AppDbContext context;
    public AuthorRepository(AppDbContext appDbContext)
    {
        this.context = appDbContext;
    }

    public async Task<IEnumerable<Author>> Search(string name, Gender? gender)
    {
        IQueryable<Author> query = context.Authors;

        if (!string.IsNullOrEmpty(name))
        {
            query = query.Where(a => a.FirstName.ToLower().Contains(name)
                || a.LastName.ToLower().Contains(name));
        }

        if (gender != null)
            query = query.Where(a => a.Gender == gender);
        Console.WriteLine(query.Count());
        return await query.ToListAsync();
    }

    public async Task<Author> AddAuthor(Author author)
    {
        var result = await context.Authors.AddAsync(author);
        await context.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<Author> DeleteAuthor(int id)
    {
        var result = await context.Authors.FirstOrDefaultAsync(x => x.AuthorId == id);

        if (result != null)
        {
            context.Authors.Remove(result);
            await context.SaveChangesAsync();
            return result;
        }
        return null;
    }

    public async Task<Author> GetAuthorById(int id)
    {
        return await context.Authors
            .Include(d => d.Department)
            .FirstOrDefaultAsync(x => x.AuthorId == id);
    }

    public async Task<Author> GetAuthorByEmail(string email)
    {
        return await context.Authors
        .FirstOrDefaultAsync(x => x.Email == email);
    }

    public async Task<IEnumerable<Author>> GetAuthors() =>
        await context.Authors
            .OrderBy(x => x.FirstName)
            .ToListAsync();
    // @_Maxo.325
    public async Task<Author> UpdateAuthor(Author author)
    {
        var result = await context.Authors
            .FirstOrDefaultAsync(x => x.AuthorId == author.AuthorId);

        if (result != null)
        {
            result.FirstName = author.FirstName;
            result.LastName = author.LastName;
            result.Email = author.Email;
            result.PhotoPath = author.PhotoPath;
            result.Bio = author.Bio;
            result.DepartmentId = author.DepartmentId;
            result.Gender = author.Gender;
            result.DateOfBirth = author.DateOfBirth;

            await context.SaveChangesAsync();
            return result;
        }
        return null;
    }
}
