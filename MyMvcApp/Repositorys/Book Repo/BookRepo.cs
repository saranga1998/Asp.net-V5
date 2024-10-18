using System.Threading.Tasks;
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
                BookName = book.BookName,
                Author = book.Author,
                Price = book.Price,
                Date = book.Date
            };

            await _dbContext.Books.AddAsync(NewBook);
            await _dbContext.SaveChangesAsync();
        }
    }
}