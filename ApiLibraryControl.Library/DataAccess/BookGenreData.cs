using ApiLibraryControl.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLibraryControl.Library.DataAccess
{
    public class BookGenreData : IBookGenreData
    {
        private readonly ISqlDataAccess _dataAccess;

        public BookGenreData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void AddBookGenre(int genreId, int bookId)
        {
            _dataAccess.SaveData("spBookGenre_AddBookGenre", new { genreId, bookId }, "LibraryDatabase");
        }

        public List<GenreModel> GetByBookId(int bookId)
        {
            var output = _dataAccess.LoadData<GenreModel, dynamic>("spBookGenre_GetByBookId", new { bookId }, "LibraryDatabase");
            return output;
        }

    }
}
