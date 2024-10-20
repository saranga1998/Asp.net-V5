using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using MyMvcApp.Models;

namespace MyMvcApp
{

    public interface IbookRepo
    {
        Task AddBook(BookModel book);
        Task<List<BookModel>> GetAllBooks();

        Task<bool> DeleteBook(string Id);

        Task AddCustomer(CustomerModel customer);
        Task<List<CustomerModel>> GetAllCustomers();
    }
}