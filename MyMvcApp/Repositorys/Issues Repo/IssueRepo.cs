using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyMvcApp;
using MyMvcApp.Models;

public class IssueRepo : IissueRepo
{
    private readonly ApplicationDbContext _dbContext;
    public IssueRepo(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddBookIssue(CustomerBookModel issue)
    {
        var Newissue = new MyMvcApp.Models.CustomerBookModel()
        {
            BorrowId = issue.BorrowId,
            IssueDate = issue.IssueDate,
            RecievedDate = issue.RecievedDate,
            Id = issue.Id,
            NIC = issue.NIC
        };
        await _dbContext.CustomerBooks.AddAsync(Newissue);
        await _dbContext.SaveChangesAsync();


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