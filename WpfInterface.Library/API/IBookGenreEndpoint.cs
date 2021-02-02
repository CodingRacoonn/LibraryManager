using System.Collections.Generic;
using System.Threading.Tasks;
using WpfInterface.Library.Models;

namespace WpfInterface.Library.API
{
    public interface IBookGenreEndpoint
    {
        Task AddBookGenre(BookGenreModel model);
        Task<List<BookGenreModel>> GetByBookId(int bookId);
    }
}