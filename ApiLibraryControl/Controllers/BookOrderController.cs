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
    public class BookOrderController : ControllerBase
    {
        private readonly IBookOrderData _data;

        public BookOrderController(IBookOrderData data)
        {
            _data = data;
        }

        [Route("AddBookOrder")]
        [HttpPost]
        public void AddBookOrder(BookOrderModel model)
        {
            _data.AddBookOrder(model);
        }


        [Route("GetByUserId/{userid}")]
        [HttpGet]
        public List<BookOrderInfoModel> GetByUserId(string userId)
        {
            var output = _data.GetByUserId(userId);
            return output;
        }

        [Route("CancelOrder")]
        [HttpPost]
        public void CancelOrder(BookOrderModel model)
        {
            _data.CancelOrder(model);
        }
    }
}
