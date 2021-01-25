using ApiLibraryControl.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLibraryControl.Library.DataAccess
{
    public class BookOrderData : IBookOrderData
    {
        private readonly ISqlDataAccess _dataAccess;

        public BookOrderData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void AddBookOrder(BookOrderModel model)
        {
            _dataAccess.SaveData("spBookOrder_AddBookOrder", new { model.BookId, model.UserId }, "LibraryDatabase");
        }

        public List<BookOrderInfoModel> GetByUserId(string userId)
        {
            var output = _dataAccess.LoadData<BookOrderInfoModel, dynamic>("spBookOrder_GetByUserId", new { userId }, "LibraryDatabase");
            return output;
        }
    }
}
