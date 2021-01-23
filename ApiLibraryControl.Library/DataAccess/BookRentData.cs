using ApiLibraryControl.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLibraryControl.Library.DataAccess
{
    public class BookRentData : IBookRentData
    {
        private readonly ISqlDataAccess _dataAccess;

        public BookRentData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void AddBookRent(BookRentModel model)
        {
            _dataAccess.SaveData("spBookRent_AddBookRent", new { model.BookId, model.UserId, model.ExpectedReturnDate }, "LibraryDatabase");
        }

        public void ProlongReturnDate(BookRentModel model)
        {
            _dataAccess.SaveData("spBookRent_ProlongReturnDate", new { model.BookId, model.UserId, model.ExpectedReturnDate, model.ProlongCount }, "LibraryDatabase");
        }

        public void BookReturned(BookRentModel model)
        {
            _dataAccess.SaveData("spBookRent_BookReturned", new { model.BookId, model.UserId, model.ReturnDate }, "LibraryDatabase");
        }

        public List<BookRentInfoModel> GetByUserId(string userId)
        {
            var output = _dataAccess.LoadData<BookRentInfoModel, dynamic>("spBookRent_GetByUserId", new { userId }, "LibraryDatabase");
            return output;
        }

    }
}
