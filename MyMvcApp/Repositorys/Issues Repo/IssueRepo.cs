using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMvcApp;
using MyMvcApp.Models;

public class IssueRepo : IissueRepo
{
    private readonly ApplicationDbContext _dbContext;
    public IssueRepo(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<List<BookModel>> GetAllBooks()
    {
        return await _dbContext.Books.ToListAsync();
    }

    public async Task<List<CustomerModel>> GetAllMembers()
    {
        return await _dbContext.Customers.ToListAsync();
    }
}