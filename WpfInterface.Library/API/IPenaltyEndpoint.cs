using System.Collections.Generic;
using System.Threading.Tasks;
using WpfInterface.Library.Models;

namespace WpfInterface.Library.API
{
    public interface IPenaltyEndpoint
    {
        Task AddPenalty(PenaltyModel model);
        Task<List<PenaltyInfoModel>> GetByUserId(int userId);
    }
}