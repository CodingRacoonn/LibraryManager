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
    public class PenaltyController : ControllerBase
    {
        private readonly IPenaltyData _data;

        public PenaltyController(IPenaltyData data)
        {
            _data = data;
        }


        [Route("AddPenalty")]
        [HttpPost]
        public void AddPenalty(PenaltyModel model)
        {
            //decimal paymentFromUI = model.Payment;
            //model.Payment = _data.AmountOfPayment(model.UserId, model.BookId);

            //if (paymentFromUI != model.Payment)
            //{
            //    // Error message about diffrence in calculation UI - API
            //    // Get UserId
            //}

           _data.AddPenalty(model);
        }


        [Route("GetByUserId/{userId}")]
        [HttpGet]
        public List<PenaltyInfoModel> GetByUserId(string userId)
        {
            var output = _data.GetByUserId(userId);
            return output;
        }
    }
}
