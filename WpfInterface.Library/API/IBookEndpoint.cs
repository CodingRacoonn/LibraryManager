using System.Collections.Generic;
using System.Threading.Tasks;
using WpfInterface.Library.Models;

namespace WpfInterface.Library.API
{
    public interface IBookEndpoint
    {
        Task AddBook(BookModel model);
        Task<List<AuthorModel>> GetAllAuthors();
        Task<List<BookModel>> GetAllBooks();
        Task<List<BookModel>> GetByAuthor(string authorFN, string authorLN);
        Task<List<BookModel>> GetByPublisher(string bookPublisher);
        Task<List<BookModel>> GetByTitle(string bookTitle);
    }
}