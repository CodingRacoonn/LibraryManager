using ApiLibraryControl.Library.Models;
using System.Collections.Generic;

namespace ApiLibraryControl.Library.DataAccess
{
    public interface IBookOrderData
    {
        void AddBookOrder(BookOrderSetupModel model);
        void CancelOrder(BookOrderSetupModel model);
        List<BookOrderInfoModel> GetByUserId(string userId);
    }
}