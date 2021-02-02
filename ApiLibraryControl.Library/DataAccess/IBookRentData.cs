using ApiLibraryControl.Library.Models;
using System.Collections.Generic;

namespace ApiLibraryControl.Library.DataAccess
{
    public interface IBookRentData
    {
        void AddBookRent(BookRentSetupModel model);
        void BookReturned(BookRentSetupModel model);
        List<BookRentInfoModel> GetByUserId(string id);
        void ProlongReturnDate(BookRentSetupModel model);
    }
}