using ApiLibraryControl.Library.DataAccess;
using ApiLibraryControl.Library.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLibraryControl.Controllers
{
    //[Authorize(Roles = "Admin,")]
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookData _data;

        public BookController(IBookData data)
        {
            _data = data;
        }

        [Route("GetAllBooks")]
        [HttpGet]
        public List<BookModel> Get()
        {
            var books = _data.GetAllBooks();
            return books;
        }

        [Route("GetByTitle/{title}")]
        [HttpGet]
        public List<BookModel> GetByTitle(string title)
        {
            var books = _data.GetByTitle(title);
            return books;
        }

        [Route("GetByPublisher/{publisher}")]
        [HttpGet]
        public List<BookModel> GetByPublisher(string publisher)
        {
            var books = _data.GetByPublisher(publisher);
            return books;
        }

        [Route("GetByAuthor/{authorFN}/{authorLN}")]
        [HttpGet]
        public List<BookModel> GetByAuthor(string authorFN, string authorLN)
        {
            var books = _data.GetByAuthor(authorFN,authorLN);
            return books;
        }

        [Route("GetAllAuthors")]
        [HttpGet]
        public List<AuthorDbModel> GetAllAuthors()
        {
            var books = _data.GetAllAuthors();
            return books;
        }

        [Route("AddBook")]
        [HttpPost]
        public void AddBook(BookModel model)
        {
            _data.AddBook(model.Title, model.Description, model.AuthorFirstName, model.AuthorLastName, model.Publisher, model.ReleaseDate, model.Quantity, model.AvailableQuantity);
        }

        //[HttpPost]
        //public void Post()
        //{
        //    string title = "Hrabia Montechristo";
        //    string description = "Hrabia Hrabi Hrabią";
        //    string authorFirstName = "Aleksander";
        //    string authorLastName = "Dumas";
        //    string publisher = "Zbychu Publish";
        //    DateTime releaseDate = new DateTime(1855, 3, 5);
        //    int quantity = 7;

        //    _data.AddBook(title,description,authorFirstName,authorLastName,publisher,releaseDate,quantity);
        //}

    }
}
