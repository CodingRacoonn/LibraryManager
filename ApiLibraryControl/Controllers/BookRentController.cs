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
    public class BookRentController : ControllerBase
    {
        private readonly IBookRentData _data;

        public BookRentController(IBookRentData data)
        {
            _data = data;
        }


        [Route("AddBookRent")]
        [HttpPost]
        public void AddBookRent(BookRentModel model)
        {
            _data.AddBookRent(model);
        }

        [Route("ProlongReturnDate")]
        [HttpPost]
        public void ProlongReturnDate(BookRentModel model)
        {
            _data.ProlongReturnDate(model);
        }

        [Route("BookReturned")]
        [HttpPost]
        public void BookReturned(BookRentModel model)
        {
            _data.BookReturned(model);
        }


        [Route("GetByUserId/{userid}")]
        [HttpGet]
        public List<BookRentInfoModel> GetByUserId(string userId)
        {
            var output = _data.GetByUserId(userId);
            return output;
        }

    }
}
