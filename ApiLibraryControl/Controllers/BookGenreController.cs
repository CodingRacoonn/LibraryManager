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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BookGenreController : ControllerBase
    {
        private readonly IBookGenreData _data;

        public BookGenreController(IBookGenreData data)
        {
            _data = data;
        }

        [Authorize(Roles = "Admin,Manager,Librarian")]
        [Route("AddBookGenre")]
        [HttpPost]
        public void AddBookGenre(BookGenreModel model)
        {
            _data.AddBookGenre(model.GenreId, model.BookId);
        }

        [Route("GetByBookId/{bookId}")]
        [HttpGet]
        public List<GenreModel> GetByBookId(int bookId)
        {
            var output = _data.GetByBookId(bookId);
            return output;
        }


    }
}
