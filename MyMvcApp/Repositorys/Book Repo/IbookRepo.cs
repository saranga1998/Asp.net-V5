using System.Drawing;
using System.Threading.Tasks;
using MyMvcApp.Models;

namespace MyMvcApp
{

    public interface IbookRepo
    {
        Task AddBook(BookModel book);

    }
}