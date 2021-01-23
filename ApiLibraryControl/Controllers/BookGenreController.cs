using ApiLibraryControl.Library.DataAccess;
using ApiLibraryControl.Library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLibraryControl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookGenreController : ControllerBase
    {
        private readonly IBookGenreData _data;

        public BookGenreController(IBookGenreData data)
        {
            _data = data;
        }

        [Route("AddBookGenre")]
        [HttpPost]
        public void AddBookGenre([FromBody] BookGenreModel model)
        {
            _data.AddBookGenre(model.GenreId, model.BookId);
        }


        [Route("GetByBookId/{id}")]
        [HttpGet]
        public List<GenreModel> GetByBookId(int bookId)
        {
            var output = _data.GetByBookId(bookId);
            return output;
        }


    }
}
