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

        Task<BookModel> GetBookById(string Id);

        Task<bool> EditBook(BookModel edit);

        Task AddCustomer(CustomerModel customer);
        Task<List<CustomerModel>> GetAllCustomers();

        Task<bool> DeleteCustomer(string Id);

        Task<CustomerModel> GetCustomerById(string Id);

        Task<bool> EditCustomer(CustomerModel edit);
    }
}