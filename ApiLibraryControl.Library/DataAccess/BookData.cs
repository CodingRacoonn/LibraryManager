using ApiLibraryControl.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLibraryControl.Library.DataAccess
{
    public class BookData : IBookData
    {
        private readonly ISqlDataAccess _dataAccess;

        public BookData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public List<BookModel> GetAllBooks()
        {
            var output = _dataAccess.LoadData<BookModel, dynamic>("spBook_GetAll", new { }, "LibraryDatabase");
            return output;
        }

        public List<AuthorDbModel> GetAllAuthors()
        {
            var output = _dataAccess.LoadData<AuthorDbModel, dynamic>("spBook_GetAllAuthors", new { }, "LibraryDatabase");
            return output;
        }

        public List<BookModel> GetByTitle(string title)
        {
            var output = _dataAccess.LoadData<BookModel, dynamic>("spBook_GetByTitle", new { title }, "LibraryDatabase");
            return output;
        }

        public List<BookModel> GetByAuthor(string authorFirstName, string authorLastName)
        {
            var output = _dataAccess.LoadData<BookModel, dynamic>("spBook_GetByAuthor", new { authorFirstName, authorLastName }, "LibraryDatabase");
            return output;
        }

        public List<BookModel> GetByPublisher(string publisher)
        {
            var output = _dataAccess.LoadData<BookModel, dynamic>("spBook_GetByPublisher", new { publisher }, "LibraryDatabase");
            return output;
        }

        public void AddBook(string title, string description, string authorFirstName, string authorLastName, string publisher, DateTime releaseDate, int quantity, int availableQuantity)
        {
            _dataAccess.SaveData("spBook_AddBook", new { title, description, authorFirstName, authorLastName, publisher, releaseDate, quantity, availableQuantity }, "LibraryDatabase");
        }

    }
}
