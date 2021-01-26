using ApiLibraryControl.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            try
            {
                // Start transaction
                _dataAccess.StartTransaction("LibraryDatabase");

                // Was book ordered?
                var orderedBook = _dataAccess.LoadDataInTransaction<BookOrderInfoModel, dynamic>("spBookOrder_GetByBookAndUserId", new { model.UserId, model.BookId });

                if (orderedBook.Count == 0 || orderedBook is null)
                {
                    int? availableQuantity = _dataAccess.LoadDataInTransaction<int, dynamic>("spBook_CheckAQById", new { Id = model.BookId }).FirstOrDefault();

                    if (availableQuantity <= 0 || availableQuantity is null)
                    {
                        //book isnt viable
                    }
                    else
                    {
                        _dataAccess.SaveDataInTransaction("spBookRent_AddBookRent_WithAQ", new { model.BookId, model.UserId, model.ExpectedReturnDate });
                    }
    
                }
                else
                {
                    _dataAccess.SaveDataInTransaction("spBookRent_AddBookRent", new { model.BookId, model.UserId, model.ExpectedReturnDate });
                    _dataAccess.SaveDataInTransaction("spBookOrder_OrderCompleted", new { model.BookId, model.UserId });
                }

                _dataAccess.CommitTransaction();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void ProlongReturnDate(BookRentModel model)
        {
            _dataAccess.SaveData("spBookRent_ProlongReturnDate", new { model.BookId, model.UserId, model.ExpectedReturnDate }, "LibraryDatabase");
        }

        public void BookReturned(BookRentModel model)
        {
            _dataAccess.SaveData("spBookRent_BookReturned", new { model.BookId, model.UserId}, "LibraryDatabase");
        }

        public List<BookRentInfoModel> GetByUserId(string userId)
        {
            var output = _dataAccess.LoadData<BookRentInfoModel, dynamic>("spBookRent_GetByUserId", new { userId }, "LibraryDatabase");
            return output;
        }

    }
}
