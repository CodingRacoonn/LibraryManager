using ApiLibraryControl.Library.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace ApiLibraryControl.Library.DataAccess
{
    public class PenaltyData : IPenaltyData
    {
        private readonly ISqlDataAccess _dataAccess;
        private readonly IConfiguration _config;

        public PenaltyData(ISqlDataAccess dataAccess, IConfiguration config)
        {
            _dataAccess = dataAccess;
            _config = config;
        }

        public void AddPenalty(PenaltyModel model)
        {
            _dataAccess.SaveData("spPenalty_AddPenalty", new { model.UserId, model.BookId, model.BookRentId, model.Payment } , "LibraryDatabase");
        }

        public List<PenaltyInfoModel> GetByUserId(string userId)
        {
            var output = _dataAccess.LoadData<PenaltyInfoModel, dynamic>("spPenalty_GetByUserId", new { userId }, "LibraryDatabase");
            return output;
        }

        public decimal AmountOfPayment(string userId, int bookId)
        {
            var rentedBooks = _dataAccess.LoadData<BookRentInfoModel, dynamic>("spBookRent_GetByUserId", new { userId }, "LibraryDatabase");

            int daysAfterReturnDate;
            string paymentPerDay = _config.GetValue<string>("PaymentPerDay");
            decimal payment = 0;

            foreach (var item in rentedBooks)
            {
                if (item.BookId == bookId)
                {
                    daysAfterReturnDate = (DateTime.Now - item.ExpectedReturnDate).Days;
                    if (daysAfterReturnDate > 0)
                    {
                        decimal calc;
                        bool valid = Decimal.TryParse(paymentPerDay, out calc);
                        payment = calc * daysAfterReturnDate;
                    }
                    break;
                }
            }

            return payment;
        }
    }
}
