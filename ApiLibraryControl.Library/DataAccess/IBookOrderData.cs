using ApiLibraryControl.Library.Models;
using System.Collections.Generic;

namespace ApiLibraryControl.Library.DataAccess
{
    public interface IBookOrderData
    {
        void AddBookOrder(BookOrderModel model);
        void CancelOrder(BookOrderModel model);
        List<BookOrderInfoModel> GetByUserId(string userId);
    }
}