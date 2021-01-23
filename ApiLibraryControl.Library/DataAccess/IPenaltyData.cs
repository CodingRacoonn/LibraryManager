using ApiLibraryControl.Library.Models;
using System.Collections.Generic;

namespace ApiLibraryControl.Library.DataAccess
{
    public interface IPenaltyData
    {
        void AddPenalty(PenaltyModel model);
        decimal AmountOfPayment(string userId, int bookId);
        List<PenaltyInfoModel> GetByUserId(string id);
    }
}