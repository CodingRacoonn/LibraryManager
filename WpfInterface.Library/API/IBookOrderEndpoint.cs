using System.Collections.Generic;
using System.Threading.Tasks;
using WpfInterface.Library.Models;

namespace WpfInterface.Library.API
{
    public interface IBookOrderEndpoint
    {
        Task AddBookOrder(BookOrderSetupModel model);
        Task CancelOrder(BookOrderSetupModel model);
        Task<List<BookOrderInfoModel>> GetByUserId(int userId);
    }
}