using KitapYonetim.Common.EF;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryManagement.API.Services
{
    public interface IBooksService
    {
        Task<IList<Book>> GetBooks();
        Task<Book> GetBookById(int id);

        Task<Book> CreateBook(Book book);
        Task UpdateBook(Book book);
        Task DeleteBook(int id);
    }
}
