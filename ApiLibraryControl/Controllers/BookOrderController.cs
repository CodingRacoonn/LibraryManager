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
        public void AddBookOrder(BookOrderSetupModel model)
        {
            _data.AddBookOrder(model);
        }

        [Route("CancelOrder")]
        [HttpPost]
        public void CancelOrder(BookOrderSetupModel model)
        {
            _data.CancelOrder(model);
        }


        [Route("GetByUserId/{userid}")]
        [HttpGet]
        public List<BookOrderInfoModel> GetByUserId(string userId)
        {
            var output = _data.GetByUserId(userId);
            return output;
        }
    }
}
