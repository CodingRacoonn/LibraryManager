using ApiLibraryControl.Library.Models;
using System.Collections.Generic;

namespace ApiLibraryControl.Library.DataAccess
{
    public interface IBookGenreData
    {
        void AddBookGenre(int genreId, int bookId);
        List<GenreModel> GetByBookId(int Id);
    }
}