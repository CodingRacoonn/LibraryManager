using ApiLibraryControl.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            int? availableQuantity = _dataAccess.LoadData<int, dynamic>("spBook_CheckAQById", new { Id = model.BookId }, "LibraryDatabase").FirstOrDefault();

            if (availableQuantity <= 0 || availableQuantity is null)
            {
                //book isnt viable
            }
            else
            {
                _dataAccess.SaveData("spBookOrder_AddBookOrder", new { model.BookId, model.UserId }, "LibraryDatabase");
            }
        }

        public List<BookOrderInfoModel> GetByUserId(string userId)
        {
            var output = _dataAccess.LoadData<BookOrderInfoModel, dynamic>("spBookOrder_PendingOrdersByUserId", new { userId }, "LibraryDatabase");
            return output;
        }
    }
}
