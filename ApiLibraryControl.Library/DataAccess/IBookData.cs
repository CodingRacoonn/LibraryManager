using ApiLibraryControl.Library.Models;
using System;
using System.Collections.Generic;

namespace ApiLibraryControl.Library.DataAccess
{
    public interface IBookData
    {
        void AddBook(string title, string description, string authorFirstName, string authorLastName, string publisher, DateTime releaseDate, int quantity);
        List<AuthorDbModel> GetAllAuthors();
        List<BookModel> GetAllBooks();
        List<BookModel> GetByAuthor(string authorFirstName, string authorLastName);
        List<BookModel> GetByPublisher(string publisher);
        List<BookModel> GetByTitle(string title);
    }
}