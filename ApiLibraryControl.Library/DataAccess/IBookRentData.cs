using ApiLibraryControl.Library.Models;
using System.Collections.Generic;

namespace ApiLibraryControl.Library.DataAccess
{
    public interface IBookRentData
    {
        void AddBookRent(BookRentModel model);
        void BookReturned(BookRentModel model);
        List<BookRentInfoModel> GetByUserId(string id);
        void ProlongReturnDate(BookRentModel model);
    }
}