using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMvcApp.Models;

namespace MyMvcApp
{

    public class BookRepo : IbookRepo
    {
        private readonly ApplicationDbContext _dbContext;

        public BookRepo(ApplicationDbContext context)
        {
            _dbContext = context;
        }
        public async Task AddBook(BookModel book)
        {
            var NewBook = new Models.BookModel()
            {
                Id = book.Id,
                BookName = book.BookName,
                Author = book.Author,
                Price = book.Price,
                Date = book.Date
            };

            await _dbContext.Books.AddAsync(NewBook);
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddCustomer(CustomerModel customer)
        {
            var NewCustomer = new Models.CustomerModel()
            {
                NIC = customer.NIC,
                CustomerName = customer.CustomerName,
                Address = customer.Address,
                ContactNo = customer.ContactNo
            };
            await _dbContext.Customers.AddAsync(NewCustomer);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<BookModel>> GetAllBooks()
        {
            var books = await _dbContext.Books.ToListAsync();

            List<BookModel> bookModels = new List<BookModel>();

            foreach (var b in books)
            {
                var result = new BookModel
                {

                    Id = b.Id,
                    BookName = b.BookName,
                    Author = b.Author,
                    Price = b.Price,
                    Date = b.Date
                };
                bookModels.Add(result);
            }
            return (bookModels);
        }

        public async Task<List<CustomerModel>> GetAllCustomers()
        {
            var customers = await _dbContext.Customers.ToListAsync();

            List<CustomerModel> customerModel = new List<CustomerModel>();

            foreach (var c in customers)
            {
                var result = new CustomerModel{
                    NIC = c.NIC,
                    CustomerName = c.CustomerName,
                    Address = c.Address,
                    ContactNo = c.ContactNo
                };
                customerModel.Add(result);
            }
            return (customerModel);
        }
    }
}